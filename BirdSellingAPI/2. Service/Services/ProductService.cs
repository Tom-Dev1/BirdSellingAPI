using AutoMapper;
using BirdSellingAPI._2._Service.IServices;
using BirdSellingAPI._2._Service.Model;
using BirdSellingAPI._3._Repository.BaseRepository;
using BirdSellingAPI._3._Repository.Data;
using BirdSellingAPI._4._Core.Model.Product;

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

        public ResponseModel GetProductByBirdCategoryID(string id)
        {
            var entity = _productRepository.Get(x => x.category_id == id).ToList();
            var responseModel = _mapper.Map<List<ResponseProductModel>>(entity);
            return new ResponseModel
            {
                Data = responseModel,
                MessageError = "",
                StatusCode = StatusCodes.Status200OK
            };
        }
    }
}
