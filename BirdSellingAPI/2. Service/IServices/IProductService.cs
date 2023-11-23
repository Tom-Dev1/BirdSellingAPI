using BirdSellingAPI._2._Service.Model;
using BirdSellingAPI._4._Core.Model.Product;

namespace BirdSellingAPI._2._Service.IServices
{
    public interface IProductService
    {
        public ResponseModel CreateProduct (IWebHostEnvironment webHostEnvironment, RequestProductModel requestProductModel);
        public ResponseModel GetListProduct(GetProductModel getProductModel);
        public ResponseModel UpdateProduct(IWebHostEnvironment webHostEnvironment, string id, RequestProductModel requestProductModel);
        public ResponseModel DeleteProduct(string id);
        public ResponseModel GetProductByID(string id);


        //public ResponseModel GetAll();


    }
}
