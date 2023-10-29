using BirdSellingAPI._2._Service.IServices;
using BirdSellingAPI._2._Service.Model.BirdCategory;
using BirdSellingAPI._2._Service.Services;
using BirdSellingAPI._4._Core.Model.UserPaymentMenthod;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BirdSellingAPI._1._Web
{

    [ApiController]
    public class UserPaymentMethodController : ControllerBase
    {
        private readonly IUserPaymentMethodService _userPaymentMenthodService;

        public UserPaymentMethodController(IUserPaymentMethodService userPaymentMethodService) 
        {
            _userPaymentMenthodService = userPaymentMethodService;

        }

        //Create
        [HttpPost]
        [Route("api/[controller]/CreateUserPaymentMenthod")]
        public IActionResult CreateUserPaymentMenthod(RequestUserPaymentModel requestUserPaymentModel)
        {
            var responseModel = _userPaymentMenthodService.CreateUserPaymentMethod(requestUserPaymentModel);
            return Ok(responseModel);
        }
        [HttpGet]
        [Route("api/[controller]/GetPaymentID")]
        public IActionResult GetPaymentID(string id)
        {
            var responseModel = _userPaymentMenthodService.GetSingle(id);
            return Ok(responseModel);

        }
        [HttpPut]
        [Route("api/[controller]/UpdateUserPaymentMenthod")]
        public IActionResult UpdateUserPaymentMenthod(string id, RequestUserPaymentModel requestUserPaymentModel)
        {
            var responseModel = _userPaymentMenthodService.UpdatePaymentMenthod(id, requestUserPaymentModel);
            return Ok(responseModel);
        }

        [HttpDelete]
        [Route("api/[controller]/DeleteUserPaymentMenthod")]
        public IActionResult DeleteUserPaymentMenthod(string id)
        {
            var responseModel = _userPaymentMenthodService.DeletePaymentMenthod(id);
            return Ok(responseModel);
        }
    }
}
