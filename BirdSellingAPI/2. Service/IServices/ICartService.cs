using BirdSellingAPI._2._Service.Model;
using BirdSellingAPI._4._Core.Model.OrderDetail;

namespace BirdSellingAPI._2._Service.IServices
{
    public interface ICartService
    {
        public ResponseModel AddProductToCart(RequestCartModel requestCartModel);
        public ResponseModel GetAllCart(string userID);
        public ResponseModel DeleteCartList(List<string> cartIdList);

    }
}
