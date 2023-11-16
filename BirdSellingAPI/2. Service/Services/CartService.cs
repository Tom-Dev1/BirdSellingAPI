using AutoMapper;
using BirdSellingAPI._2._Service.IServices;
using BirdSellingAPI._2._Service.Model;
using BirdSellingAPI._3._Repository.BaseRepository;
using BirdSellingAPI._3._Repository.Data;
using BirdSellingAPI._4._Core.Model.OrderDetail;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

namespace BirdSellingAPI._2._Service.Services
{
    public class CartService : ICartService
    {
        private readonly IRepositoryBase<CartEntity> _CartRepository;
        private readonly IRepositoryBase<ProductEntity> _productRepository;
        private readonly IMapper _mapper;

        public CartService(IRepositoryBase<CartEntity> repositoryBase, IRepositoryBase<ProductEntity> productRepository
            , IMapper mapper)
        {
            _CartRepository = repositoryBase;
            _productRepository = productRepository;
            _mapper = mapper;
        }
        public ResponseModel AddProductToCart(RequestCartModel requestCartModel)
        {
            var cartEntity = _mapper.Map<CartEntity>(requestCartModel);
            //kiểm tra xem đã add sản phẩm vào chưa
            var ExistedProductInCart = _CartRepository.GetSingle(x => x.product_id == cartEntity.product_id
            && x.user_id == requestCartModel.user_id);

            if (ExistedProductInCart != null)
            {
                return new ResponseModel
                {
                    MessageError = "Sản phẩm đã được thêm vào giỏ hàng",
                };
            }

            var productEntity = _productRepository.GetSingle(x => x.Id == cartEntity.product_id);
            if (productEntity.statusProduct == _4._Core.EnumCore.StatusProduct.DaBan ||
                productEntity.statusProduct == _4._Core.EnumCore.StatusProduct.DaXoa)
            {
                return new ResponseModel
                {
                    MessageError = "Sản phẩm không tồn tại",
                    StatusCode = StatusCodes.Status400BadRequest
                };
            }
            cartEntity.price = productEntity.price * (((decimal)100 - productEntity.Discount) / 100);
            cartEntity.quantity = 1;
            cartEntity.order_id = null;
            _CartRepository.Create(cartEntity);
            return new ResponseModel
            {
                Data = cartEntity,
                StatusCode = 200
            };
        }

        public ResponseModel UpdateProductCart(RequestCartModel requestCartModel)
        {
            throw new NotImplementedException();
        }

        public ResponseModel GetAllCart()
        {
            var cartEntity = _CartRepository.Get(x => x.order_id == null, x => x.Product);
            var cartResponseModel = _mapper.Map<List<ResponseCartModel>>(cartEntity.ToList());
            return new ResponseModel
            {
                Data = cartResponseModel,
                StatusCode = 200,
                MessageError = ""
            };
        }

    }
}
