using BirdSellingAPI._2._Service.Model;
using BirdSellingAPI._4._Core.Model.UserPaymentMenthod;

namespace BirdSellingAPI._2._Service.IServices
{
    public interface IUserPaymentMethodService
    {
        public ResponseModel CreateUserPaymentMethod(RequestUserPaymentModel entity);
        public ResponseModel GetSingle(string id);
        public ResponseModel UpdatePaymentMenthod(string id, RequestUserPaymentModel requestUserPaymentModel);
        public ResponseModel DeletePaymentMenthod(string id);




    }
}
