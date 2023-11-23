using BirdSellingAPI._2._Service.IServices;
using BirdSellingAPI._2._Service.Model.BirdCategory;
using BirdSellingAPI._4._Core.Model.OrderDetail;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BirdSellingAPI._1._Web
{
    [ApiController]
    public class CartController : ControllerBase
    {
        private readonly ICartService _cartService;

        public CartController(ICartService cartService) 
        {
            _cartService = cartService;
        }
        //Create
        [HttpPost]
        [Route("api/[controller]/Add-Product-To-Cart")]
        public IActionResult AddProductToCart(RequestCartModel requestCartModel)
        {
            var responseModel = _cartService.AddProductToCart(requestCartModel);
            return Ok(responseModel);
        }

        [HttpGet]
        [Route("api/[controller]/Get-All-Cart")]
        public IActionResult GetAllCart(string userID)
        {
            var responseModel = _cartService.GetAllCart(userID);
            return Ok(responseModel);
        }
        [HttpDelete]
        [Route("api/[controller]/Delete-Carts")]
        public IActionResult DeleteCarts(List<string> cartIdList)
        {
            var responseModel = _cartService.DeleteCartList(cartIdList);
            return Ok(responseModel);
        }
    }
}
