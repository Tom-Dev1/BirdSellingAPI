using BirdSellingAPI._2._Service.Model;
using BirdSellingAPI._2._Service.Model.BirdCategory;

namespace BirdSellingAPI._2._Service.IServices
{
    public interface IBirdCategoryService
    {
        public ResponseModel CreateBirdCategory(RequestBirdCategoryModel requestBirdCategory);
        public ResponseModel GetAll();
        public ResponseModel GetBirdCategoryByName(string? name);
    }
}
