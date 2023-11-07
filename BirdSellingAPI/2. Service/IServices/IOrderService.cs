using BirdSellingAPI._2._Service.Model;
using BirdSellingAPI._4._Core.Model.Order;

namespace BirdSellingAPI._2._Service.IServices
{
    public interface IOrderService
    {
        public ResponseModel CreateOrder(RequestOrderModel requestOrderModel);
        public ResponseModel GetSingle(string id);
        public ResponseModel GetAll();


    }
}
