using BirdSellingAPI._2._Service.IServices;
using BirdSellingAPI._2._Service.Model.BirdCategory;
using BirdSellingAPI._4._Core.Model.Auth;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BirdSellingAPI._1._Web
{
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost]
        [Route("api/[controller]/SignUpUser")]
        public IActionResult CreateUser(SignUpModel signUpModel)
        {
            var responseModel = _authService.SignUp(signUpModel);
            return Ok(responseModel);
        }

        [HttpPost]
        [Route("api/[controller]/SignInUser")]
        public IActionResult CreateUser(SignInModel signIpModel)
        {
            var responseModel = _authService.SignIn(signIpModel);
            return Ok(responseModel);
        }

        //[HttpPut]
        //[Route("api/[controller]/Verify-Account")]
        //public IActionResult VerifyAccount(string username, string verifyKey)
        //{
        //    var responseModel = _authService.VerifyEmail(username, verifyKey);
        //    return Ok(responseModel);
        //}
    }
}
