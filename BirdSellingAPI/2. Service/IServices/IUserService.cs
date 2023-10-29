using BirdSellingAPI._2._Service.Model;

namespace BirdSellingAPI._2._Service.IServices
{
    public interface IUserService
    {
        public ResponseModel GetAll();
        public ResponseModel GetSingle(string id);

    }
}
