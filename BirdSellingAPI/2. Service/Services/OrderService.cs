using AutoMapper;
using Azure.Messaging;
using BirdSellingAPI._2._Service.IServices;
using BirdSellingAPI._2._Service.Model;
using BirdSellingAPI._2._Service.Model.BirdCategory;
using BirdSellingAPI._3._Repository.BaseRepository;
using BirdSellingAPI._3._Repository.Data;
using BirdSellingAPI._3._Repository.Repository;
using BirdSellingAPI._4._Core.EnumCore;
using BirdSellingAPI._4._Core.Model.Order;
using BirdSellingAPI._4._Core.Model.User;
using Microsoft.EntityFrameworkCore.Diagnostics.Internal;
using System.Reflection.Metadata.Ecma335;

namespace BirdSellingAPI._2._Service.Services
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IMapper _mapper;
        private readonly IRepositoryBase<CartEntity> _cartRepository;
        private readonly IRepositoryBase<ProductEntity> _productRepository;

        public OrderService(IOrderRepository orderRepository, IMapper mapper
            , IRepositoryBase<CartEntity> cartRepository)
        {
            _orderRepository = orderRepository;
            _mapper = mapper;
            _cartRepository = cartRepository;
        }

        public ResponseModel CreateOrder(RequestOrderModel requestOrderModel)
        {
            var listCartEntity = _cartRepository.Get(x => requestOrderModel.listIDCarts.Contains(x.Id), 
                x => x.Product).ToList();
            //check don hang rong
            if (listCartEntity == null)
            {
                return new ResponseModel
                {
                    MessageError = "Không thể thêm sản phẩm"
                };
            }

            //Check cac product da ban hay chua
            var productInValid = listCartEntity.Any(
               x => x.Product.statusProduct == _4._Core.EnumCore.StatusProduct.DaBan 
            || x.Product.statusProduct == _4._Core.EnumCore.StatusProduct.DaXoa);
            if (productInValid)
            {
                return new ResponseModel
                {
                    MessageError = "Một số sản phẩm không tồn tại, vui lòng kiểm tra lại",
                    StatusCode = StatusCodes.Status400BadRequest
                };
            }
            var totalOrder = (decimal) 0;
            foreach (var item in listCartEntity)
            {
                totalOrder += (decimal) item.price!;
            }
            var orderEntity = _mapper.Map<OrderEntity>(requestOrderModel);
            orderEntity.orderStatus = _4._Core.EnumCore.OrderStatus.ChoXacNhan;
            orderEntity.orderTotal = totalOrder;
            orderEntity.order_date = DateTime.UtcNow;

            listCartEntity.ForEach(x =>
            {
                x.order_id = orderEntity.Id;
                x.user_id = orderEntity.user_id;
                x.Product.statusProduct = _4._Core.EnumCore.StatusProduct.DaBan;
            });

            


            var resultCreate = _orderRepository.CreateOrder(orderEntity, listCartEntity);

            if (resultCreate)
            {
                return new ResponseModel
                {
                    Data = orderEntity,
                    StatusCode = 200
                };
            }
            else
            {
                return new ResponseModel
                {
                    MessageError = "Lỗi tạo đơn hàng không thành công",
                    StatusCode = StatusCodes.Status500InternalServerError
                };
            }
        }

        public ResponseModel GetAll()
        {
            var orderEntity = _orderRepository.Get(null, x => x.User).ToList();
            var response = _mapper.Map<List<ResponseOrderModel>>(orderEntity.ToList());
            return new ResponseModel
            {
                Data = response,
                MessageError = "",
                StatusCode = StatusCodes.Status200OK
            };
        }
        public ResponseModel GetSingle(string id)
        {
            var orderEntity = _orderRepository.GetSingle(x => x.Id.Equals(id));
            var responseOrder = _mapper.Map<ResponseOrderModel>(orderEntity);
            return new ResponseModel
            {
                Data = orderEntity,
                MessageError = "",
                StatusCode = StatusCodes.Status200OK
            };
        }

        public ResponseModel UpdateStatusOrder(string orderid, OrderStatus orderStatus)
        {
            var orderentity = _orderRepository.GetSingle(x => x.Id == orderid);
            orderentity.orderStatus = orderStatus;
            _orderRepository.Update(orderentity);
            return new ResponseModel()
            {
                MessageError = "cập nhật trạng thái thành công",
                StatusCode = StatusCodes.Status200OK
            };
        }

        //public ResponseModel UpdateDangVanChuyen(string orderID)
        //{
        //    var orderEntity = _orderRepository.GetSingle(x => x.Id == orderID);
        //    orderEntity.orderStatus = _4._Core.EnumCore.OrderStatus.DangVanChuyen;
        //    _orderRepository.Update(orderEntity);
        //    return new ResponseModel()
        //    {
        //        MessageError = "Cập nhật trạng thái thành công",
        //        StatusCode = StatusCodes.Status200OK
        //    };
        //}

        //public ResponseModel UpdateDaThanhToan(string orderID)
        //{
        //    var orderEntity = _orderRepository.GetSingle(x => x.Id == orderID);
        //    orderEntity.orderStatus = _4._Core.EnumCore.OrderStatus.DaThanhToan;
        //    _orderRepository.Update(orderEntity);
        //    return new ResponseModel()
        //    {
        //        MessageError = "Cập nhật trạng thái thành công",
        //        StatusCode = StatusCodes.Status200OK
        //    };
        //}

        //public ResponseModel UpdateDaXacNhan(string orderID)
        //{
        //    var orderEntity = _orderRepository.GetSingle(x => x.Id == orderID);
        //    if (orderEntity.orderStatus == _4._Core.EnumCore.OrderStatus.ChoXacNhan)
        //    {
        //        orderEntity.orderStatus = _4._Core.EnumCore.OrderStatus.DaXacNhan;
        //        _orderRepository.Update(orderEntity);
        //        return new ResponseModel { Data = orderEntity, StatusCode = StatusCodes.Status200OK };
        //    }
        //    return new ResponseModel()
        //    {
        //        MessageError = "Không thể cập nhật trạng thái",
        //        StatusCode = StatusCodes.Status400BadRequest
        //    };
        //}

        //public ResponseModel UpdateHetHang(string orderID)
        //{
        //    var orderEntity = _orderRepository.GetSingle(x => x.Id == orderID);
        //    orderEntity.orderStatus = _4._Core.EnumCore.OrderStatus.HetHang;
        //    _orderRepository.Update(orderEntity);
        //    return new ResponseModel()
        //    {
        //        MessageError = "Cập nhật trạng thái thành công",
        //        StatusCode = StatusCodes.Status200OK
        //    };
        //}

        //public ResponseModel UpdateHoanTraHang(string orderID)
        //{
        //    var orderEntity = _orderRepository.GetSingle(x => x.Id == orderID);
        //    orderEntity.orderStatus = _4._Core.EnumCore.OrderStatus.HoanTraHang;
        //    _orderRepository.Update(orderEntity);
        //    return new ResponseModel()
        //    {
        //        MessageError = "Cập nhật trạng thái thành công",
        //        StatusCode = StatusCodes.Status200OK
        //    };
        //}

        //public ResponseModel UpdateHuyDon(string orderID)
        //{
        //    var orderEntity = _orderRepository.GetSingle(x => x.Id == orderID);
        //    orderEntity.orderStatus = _4._Core.EnumCore.OrderStatus.HuyDon;
        //    _orderRepository.Update(orderEntity);
        //    return new ResponseModel()
        //    {
        //        MessageError = "Cập nhật trạng thái thành công",
        //        StatusCode = StatusCodes.Status200OK
        //    };
        //}

        //public ResponseModel UpdateXacNhanHoanHang(string orderID)
        //{
        //    var orderEntity = _orderRepository.GetSingle(x => x.Id == orderID);
        //    if (orderEntity.orderStatus == _4._Core.EnumCore.OrderStatus.ChoXacNhan)
        //    {
        //        orderEntity.orderStatus = _4._Core.EnumCore.OrderStatus.DaXacNhan;
        //        _orderRepository.Update(orderEntity);
        //        return new ResponseModel { Data = orderEntity, StatusCode = StatusCodes.Status200OK };
        //    }
        //    return new ResponseModel()
        //    {
        //        MessageError = "Không thể cập nhật trạng thái",
        //        StatusCode = StatusCodes.Status400BadRequest
        //    };
        //}

    }
}
