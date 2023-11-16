using BirdSellingAPI._2._Service.IServices;
using BirdSellingAPI._2._Service.Model.BirdCategory;
using BirdSellingAPI._2._Service.Services;
using BirdSellingAPI._4._Core.Model.UserReview;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BirdSellingAPI._1._Web
{

    [ApiController]
    public class UserReviewController : ControllerBase
    {
        private readonly IUserReviewModelService _userReviewService;

        public UserReviewController(IUserReviewModelService userReviewModelService)
        { 
            _userReviewService = userReviewModelService;
        }
        //Create
        [HttpPost]
        [Route("api/[controller]/CreateUserReview")]
        public IActionResult CreateUserReview(RequestUserReviewModel requestUserReviewModel)
        {
            var responseModel = _userReviewService.CreateUserReview(requestUserReviewModel);
            return Ok(responseModel);
        }

        [HttpGet]
        [Route("api/[controller]/GetAllUserReview")]
        public IActionResult GetAllUserReview()
        {
            var responseModel = _userReviewService.GetAll();
            return Ok(responseModel);
        }


        [HttpGet]
        [Route("api/[controller]/GetSingleID")]
        public IActionResult GetSingleID(string id)
        {
            var responseModel = _userReviewService.GetSingle(id);
            return Ok(responseModel);

        }
        [HttpPut]
        [Route("api/[controller]/UpdateReview")]
        public IActionResult UpdateReview(string id, RequestUserReviewModel requestUserReviewModel)
        {
            var responseModel = _userReviewService.UpdateReview(id, requestUserReviewModel);
            return Ok(responseModel);
        }
        [HttpDelete]
        [Route("api/[controller]/DeleteUseReview")]
        public IActionResult DeleteUseReview(string id)
        {
            var responseModel = _userReviewService.DeleteUseReview(id);
            return Ok(responseModel);
        }
    }
}
