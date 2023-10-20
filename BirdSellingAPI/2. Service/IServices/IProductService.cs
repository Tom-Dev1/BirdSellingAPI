using BirdSellingAPI._2._Service.Model;
using BirdSellingAPI._4._Core.Model.Product;

namespace BirdSellingAPI._2._Service.IServices
{
    public interface IProductService
    {
        public ResponseModel CreateProduct (RequestProductModel requestProductModel);
        public ResponseModel GetProductByBirdCategoryID(string id);

    }
}
