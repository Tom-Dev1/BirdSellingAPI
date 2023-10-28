using BirdSellingAPI._2._Service.IServices;
using BirdSellingAPI._2._Service.Model.BirdCategory;
using BirdSellingAPI._2._Service.Services;
using BirdSellingAPI._4._Core.Model.PaymentType;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BirdSellingAPI._1._Web
{
    
    [ApiController]
    public class PaymentTypeController : ControllerBase
    {
        private readonly IPaymentTypeService _paymentTypeService;

        public PaymentTypeController(IPaymentTypeService paymentTypeService) 
        {
             _paymentTypeService = paymentTypeService;
        }
        [HttpPost]
        [Route("api/[controller]/CreatePaymentType")]
        public IActionResult CreatePaymentType(RequestPaymentTypeModel requestPaymentTypeModel)
        {
            var responseModel = _paymentTypeService.CreatePaymentType(requestPaymentTypeModel);
            return Ok(responseModel);
        }
        [HttpGet]
        [Route("api/[controller]/GetSingleID")]
        public IActionResult GetSingleID(string id)
        {
            var responseModel = _paymentTypeService.GetSingleID(id);
            return Ok(responseModel);

        }
        [HttpPut]
        [Route("api/[controller]/UpdatePaymentType")]
        public IActionResult UpdatePaymentType(string id, RequestPaymentTypeModel requestPaymentTypeModel)
        {
            var responseModel = _paymentTypeService.UpdatePaymentType(id, requestPaymentTypeModel);
            return Ok(responseModel);
        }

        [HttpDelete]
        [Route("api/[controller]/DeletePaymentType")]
        public IActionResult DeletePaymentType(string id)
        {
            var responseModel = _paymentTypeService.DeletePaymentType(id);
            return Ok(responseModel);
        }
    }

}
