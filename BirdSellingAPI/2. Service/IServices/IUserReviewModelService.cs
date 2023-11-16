using BirdSellingAPI._2._Service.Model;
using BirdSellingAPI._4._Core.Model.UserReview;

namespace BirdSellingAPI._2._Service.IServices
{
    public interface IUserReviewModelService
    {
        public ResponseModel CreateUserReview(RequestUserReviewModel entity);
        public ResponseModel GetAll();
        public ResponseModel GetSingle(string id);
        public ResponseModel UpdateReview(string id, RequestUserReviewModel requestUserReviewModel);
        public ResponseModel DeleteUseReview(string id);


    }
}
