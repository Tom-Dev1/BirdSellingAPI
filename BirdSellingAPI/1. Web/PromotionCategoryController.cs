using BirdSellingAPI._2._Service.IServices;
using BirdSellingAPI._2._Service.Model.BirdCategory;
using BirdSellingAPI._2._Service.Services;
using BirdSellingAPI._4._Core.Model.PromotionCategory;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BirdSellingAPI._1._Web
{
    [ApiController]
    public class PromotionCategoryController : ControllerBase
    {
        private readonly IPromotionCategoryService _promotionCategoryService;

        public PromotionCategoryController(IPromotionCategoryService promotionCategoryService)
        {
            _promotionCategoryService  = promotionCategoryService;
        }

        //Create
        [HttpPost]
        [Route("api/[controller]/CreatePromotionCategory")]
        public IActionResult CreatePromotionCategory(RequestPromotionCategoryModel requestPromotionCategoryModel)
        {
            var responseModel = _promotionCategoryService.CreatePromotionCategory(requestPromotionCategoryModel);
            return Ok(responseModel);
        }
        //Get ALL
        [HttpGet]
        [Route("api/[controller]/GetAllPromotionCategory")]
        public IActionResult GetAllPromotionCategory()
        {
            var responseModel = _promotionCategoryService.GetAll();
            return Ok(responseModel);
        }
        //Single ID
        [HttpGet]
        [Route("api/[controller]/GetSingleID")]
        public IActionResult GetSingleID(string id)
        {
            var responseModel = _promotionCategoryService.GetSingleID(id);
            return Ok(responseModel);

        }
        [HttpPut]
        [Route("api/[controller]/UpdatePromotionCategory")]
        public IActionResult UpdateBirdCategory(string id, RequestPromotionCategoryModel requestPromotionCategoryModel)
        {
            var responseModel = _promotionCategoryService.UpdatePromotionCategory(id, requestPromotionCategoryModel);
            return Ok(responseModel);
        }

        [HttpDelete]
        [Route("api/[controller]/DeletePromotionCategory")]
        public IActionResult DeletePromotionCategory(string id)
        {
            var responseModel = _promotionCategoryService.DeletePromotionCategory(id);
            return Ok(responseModel);
        }
    }
}
