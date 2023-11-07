using BirdSellingAPI._2._Service.IServices;
using BirdSellingAPI._2._Service.Services;
using BirdSellingAPI._4._Core.Model.Order;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BirdSellingAPI._1._Web
{
  
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _orderService;

        public OrderController(IOrderService orderService )
        {
            _orderService = orderService;
        }
        [HttpGet]
        [Route("api/[controller]/GetAll")]
        public IActionResult GetAllRole()
        {
            var responseModel = _orderService.GetAll();
            return Ok(responseModel);
        }


        [HttpGet]
        [Route("api/[controller]/GetSingleID")]
        public IActionResult GetSingleID(string id)
        {
            var responseModel = _orderService.GetSingle(id);
            return Ok(responseModel);

        }

        [HttpPost]
        [Route("api/[controller]/Create-Order")]
        public IActionResult CreateOrder(RequestOrderModel requestOrderModel)
        {
            var responseModel = _orderService.CreateOrder(requestOrderModel);
            return Ok(responseModel);

        }

    }
}
