using BirdSellingAPI._2._Service.Model;
using BirdSellingAPI._4._Core.Model.PaymentType;

namespace BirdSellingAPI._2._Service.IServices
{
    public interface IPaymentTypeService
    {
        public ResponseModel CreatePaymentType(RequestPaymentTypeModel entity);
        public ResponseModel GetSingleID(string id);
        public ResponseModel UpdatePaymentType(string id, RequestPaymentTypeModel requestPaymentTypeModel);
        public ResponseModel DeletePaymentType(string id);

    }
}
