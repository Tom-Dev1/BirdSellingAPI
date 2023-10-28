using BirdSellingAPI._2._Service.Model;
using BirdSellingAPI._4._Core.Model.PromotionCategory;

namespace BirdSellingAPI._2._Service.IServices
{
    public interface IPromotionCategoryService
    {
        public ResponseModel CreatePromotionCategory(RequestPromotionCategoryModel entity);
        public ResponseModel GetAll();
        public ResponseModel GetSingleID(string id);
        public ResponseModel UpdatePromotionCategory(string id, RequestPromotionCategoryModel requestPromotionCategoryModel);
        public ResponseModel DeletePromotionCategory(string id);






    }
}
