using BirdSellingAPI._2._Service.Model;
using BirdSellingAPI._4._Core.Model.User;

namespace BirdSellingAPI._2._Service.IServices
{
    public interface IUserService
    {
        public ResponseModel GetAll();
        public ResponseModel GetSingle(string id);
        public ResponseModel UpdateUser(string id, RequestUserModel requestUserModel);
        public ResponseModel DeleteUser(string id);
    }
}
