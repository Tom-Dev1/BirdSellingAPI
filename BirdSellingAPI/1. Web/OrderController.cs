using BirdSellingAPI._2._Service.IServices;
using BirdSellingAPI._2._Service.Services;
using BirdSellingAPI._4._Core.EnumCore;
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

        /// <summary>
        /// <!--
        /// ChoXacNhan = 1, DaXacNhan = 2, DangVanChuyen = 3, DaThanhToan = 4, HuyDon = 5, HoanTraHang = 6, HetHang = 7,
        /// -->
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// <!--
        /// ChoXacNhan = 1, DaXacNhan = 2, DangVanChuyen = 3, DaThanhToan = 4, HuyDon = 5, HoanTraHang = 6, HetHang = 7,
        /// -->
        /// </summary>
        /// <param name="orderId"></param>
        /// <param name="orderStatus"></param>
        /// <returns></returns>
        [HttpPut]
        [Route("api/[controller]/Update-Status-Product")]
        public IActionResult UpdateStatusOrder(string orderId, OrderStatus orderStatus)
        {
            var responseModel = _orderService.UpdateStatusOrder(orderId, orderStatus);
            return Ok(responseModel);

        }

        //[HttpPut]
        //[Route("api/[controller]/Update-DangVanChuyen")]
        //public IActionResult UpdateDangVanChuyen(string orderId)
        //{
        //    var responseModel = _orderService.UpdateDangVanChuyen(orderId);
        //    return Ok(responseModel);

        //}

        //[HttpPut]
        //[Route("api/[controller]/Update-DaThanhToan")]
        //public IActionResult UpdateDaThanhToan(string orderId)
        //{
        //    var responseModel = _orderService.UpdateDaThanhToan(orderId);
        //    return Ok(responseModel);

        //}

        //[HttpPut]
        //[Route("api/[controller]/Update-HoanTraHang")]
        //public IActionResult UpdateHoanTraHang(string orderId)
        //{
        //    var responseModel = _orderService.UpdateHoanTraHang(orderId);
        //    return Ok(responseModel);

        //}


        //[HttpPut]
        //[Route("api/[controller]/Update-HetHang")]
        //public IActionResult UpdateHetHang(string orderId)
        //{
        //    var responseModel = _orderService.UpdateHetHang(orderId);
        //    return Ok(responseModel);

        //}

        //[HttpPut]
        //[Route("api/[controller]/Update-HuyDon")]
        //public IActionResult UpdateHuyDon(string orderId)
        //{
        //    var responseModel = _orderService.UpdateHuyDon(orderId);
        //    return Ok(responseModel);

        //}


    }
}
