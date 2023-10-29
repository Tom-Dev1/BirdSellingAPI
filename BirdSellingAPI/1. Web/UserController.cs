using BirdSellingAPI._2._Service.IServices;
using BirdSellingAPI._2._Service.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BirdSellingAPI._1._Web
{
   
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        { 
            _userService = userService;
        }
        //Get All;
        [HttpGet]
        [Route("api/[controller]/GetAllUser")]
        public IActionResult GetAllUser()
        {
            var responseModel = _userService.GetAll();
            return Ok(responseModel);
        }
        // GET ID
        [HttpGet]
        [Route("api/[controller]/GetSingleID")]
        public IActionResult GetSingleID(string id)
        {
            var responseModel = _userService.GetSingle(id);
            return Ok(responseModel);

        }
    }
}
