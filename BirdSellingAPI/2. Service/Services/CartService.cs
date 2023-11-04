﻿using AutoMapper;
using BirdSellingAPI._2._Service.IServices;
using BirdSellingAPI._2._Service.Model;
using BirdSellingAPI._3._Repository.BaseRepository;
using BirdSellingAPI._3._Repository.Data;
using BirdSellingAPI._4._Core.Model.OrderDetail;
using Microsoft.EntityFrameworkCore;

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
            var productEntity = _productRepository.GetSingle(x => x.Id == cartEntity.product_id);
            cartEntity.price = productEntity.price * ( (100 - productEntity.Discount) / 100);
            if (cartEntity == null)
            {
                return new ResponseModel
                {
                    MessageError = "Loi khong them duoc san pham vao gio hang",
                    StatusCode = StatusCodes.Status400BadRequest
                };
            }
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
            var cartEntity = _CartRepository.Get(null, x => x.Product).ToList();
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