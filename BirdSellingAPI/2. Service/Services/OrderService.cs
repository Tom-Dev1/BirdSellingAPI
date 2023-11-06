using AutoMapper;
using BirdSellingAPI._2._Service.IServices;
using BirdSellingAPI._2._Service.Model;
using BirdSellingAPI._2._Service.Model.BirdCategory;
using BirdSellingAPI._3._Repository.BaseRepository;
using BirdSellingAPI._3._Repository.Data;
using BirdSellingAPI._4._Core.Model.Order;
using BirdSellingAPI._4._Core.Model.User;

namespace BirdSellingAPI._2._Service.Services
{
    public class OrderService : IOrderService
    {
        private readonly IRepositoryBase<OrderEntity> _orderRepository;
        private readonly IMapper _mapper;

        public OrderService(IRepositoryBase<OrderEntity> repositoryBase, IMapper mapper)
        {
            _orderRepository = repositoryBase;
            _mapper = mapper;
        }

        public ResponseModel CreateOrder(string id)
        {
            throw new NotImplementedException();
        }

        public ResponseModel GetAll()
        {
            var orderEntity = _orderRepository.GetAll().ToList();
            var response = _mapper.Map<List<ResponseOrderModel>>(orderEntity.ToList());
            return new ResponseModel
            {
                Data = orderEntity,
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
    }
}
