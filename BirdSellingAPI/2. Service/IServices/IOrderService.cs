using BirdSellingAPI._2._Service.Model;

namespace BirdSellingAPI._2._Service.IServices
{
    public interface IOrderService
    {
        public ResponseModel CreateOrder(string id);
        public ResponseModel GetSingle(string id);
        public ResponseModel GetAll();


    }
}
