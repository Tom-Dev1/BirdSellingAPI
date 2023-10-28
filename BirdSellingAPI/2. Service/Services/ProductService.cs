using AutoMapper;
using BirdSellingAPI._2._Service.IServices;
using BirdSellingAPI._2._Service.Model;
using BirdSellingAPI._2._Service.Model.BirdCategory;
using BirdSellingAPI._3._Repository.BaseRepository;
using BirdSellingAPI._3._Repository.Data;
using BirdSellingAPI._4._Core.Model.Product;
using Microsoft.IdentityModel.Tokens;

namespace BirdSellingAPI._2._Service.Services
{
    public class ProductService : IProductService
    {
        private readonly IRepositoryBase<ProductEntity> _productRepository;
        private readonly IMapper _mapper;

        public ProductService(IRepositoryBase<ProductEntity> repositoryBase, IMapper mapper) 
        {
            _productRepository = repositoryBase;
            _mapper = mapper;
        }
        public ResponseModel CreateProduct(RequestProductModel requestProductModel)
        {
            var entity = _mapper.Map<ProductEntity>(requestProductModel);
            _productRepository.Create(entity);
            return new ResponseModel
            {
                Data = entity,
                MessageError = "",
                StatusCode = StatusCodes.Status200OK
            };
        }

        public ResponseModel DeleteProduct(string id)
        {
            var productEntity = _productRepository.GetById(id);
            if (productEntity == null)
            {
                return new ResponseModel
                {
                    StatusCode = StatusCodes.Status404NotFound,
                    MessageError = "Khong tim thay san pham",
                };
            }
            _productRepository.Delete(productEntity);
            return new ResponseModel
            {
                StatusCode = StatusCodes.Status200OK
            };
        }

        public ResponseModel GetListProduct(GetProductModel getProductModel)
        {
            if (getProductModel.category_id == null)
            {
                getProductModel.category_id = "";
            }
            var responseProductList = _productRepository.Get(x => x.category_id.Contains(getProductModel.category_id)
            && x.name.Contains(getProductModel.name) 
            && (getProductModel.priceFrom <= x.price && x.price <= getProductModel.priceTo)).ToList();
            if (getProductModel.is_egg.HasValue)
            {
                responseProductList = responseProductList.Where(x => x.is_egg == getProductModel.is_egg).ToList();
            }
            if (getProductModel.sex.HasValue)
            {
                responseProductList = responseProductList.Where(x => x.sex == getProductModel.sex).ToList();
            }
            return new ResponseModel
            {
                Data = responseProductList,
                StatusCode = StatusCodes.Status200OK,
            };
        }

        public ResponseModel GetProductByID(string id)
        {
            var entity = _productRepository.GetSingle(x => x.Id.Equals(id));
            var responseModel = _mapper.Map<ResponseProductModel>(entity);
            return new ResponseModel
            {
                Data = responseModel,
                MessageError = "",
                StatusCode = StatusCodes.Status200OK
            };
        }

        public ResponseModel UpdateProduct(string id, RequestProductModel requestProductModel)
        {
            var productEntity = _productRepository.GetSingle(x => x.Id.Equals(id));
            if (productEntity == null)
            {
                return new ResponseModel
                {
                    MessageError = "Khong tim thay",
                    StatusCode = StatusCodes.Status404NotFound
                };
            }
            _mapper.Map(requestProductModel, productEntity);
            _productRepository.Update(productEntity);
            //_birdCategoryRepository.Delete(birdCategoryEntity);
            return new ResponseModel
            {
                StatusCode = StatusCodes.Status200OK
            };
        }
    }
}
