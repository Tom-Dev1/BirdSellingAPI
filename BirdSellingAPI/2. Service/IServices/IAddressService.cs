using BirdSellingAPI._2._Service.Model;
using BirdSellingAPI._4._Core.Model.Address;

namespace BirdSellingAPI._2._Service.IServices
{
    public interface IAddressService
    {
        public ResponseModel CreateAddress(RequestAddressModel requestAddressModel);
       
        public ResponseModel GetAll();
        public ResponseModel GetSingleID(string id);
        public ResponseModel UpdateAddress(string id, RequestAddressModel requestAddressModel);
        public ResponseModel DeleteAddress(string id);

    }
}
