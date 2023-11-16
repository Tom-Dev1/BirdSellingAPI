using BirdSellingAPI._2._Service.IServices;
using BirdSellingAPI._2._Service.Model.BirdCategory;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BirdSellingAPI._1._Web
{
    [ApiController]
    public class BirdCategoryController : ControllerBase
    {
        private readonly IBirdCategoryService _birdCategoryService;

        public BirdCategoryController(IBirdCategoryService birdCategoryService) 
        {
            _birdCategoryService = birdCategoryService;
        }

        //Create
        [HttpPost]
        [Route("api/[controller]/CreateBirdCategory")]
        public IActionResult CreateBirdCategory (RequestBirdCategoryModel requestBirdCategoryModel)
        {
            var responseModel = _birdCategoryService.CreateBirdCategory (requestBirdCategoryModel);
            return Ok(responseModel);
        }

        [HttpGet]
        [Route("api/[controller]/GetAll")]
        public IActionResult GetAllBirdCategory()
        {
            var responseModel = _birdCategoryService.GetAll();
            return Ok(responseModel);
        }

        [HttpGet]
        [Authorize(AuthenticationSchemes = "Bearer", Roles = ("Admin, Manager"))]
        [Route("api/[controller]/GetByName")]
        public IActionResult GetAllBirdCategory(string name)
        {
            var responseModel = _birdCategoryService.GetBirdCategoryByName(name);
            return Ok(responseModel);
        }

        [HttpGet]
        [Route("api/[controller]/GetSingleID")]
        public IActionResult GetSingleID(string id)
        {
            var responseModel = _birdCategoryService.GetSingle(id);
            return Ok(responseModel);  
            
        }
        [HttpPut]
        [Route("api/[controller]/UpdateBirdCategory")]
        public IActionResult UpdateBirdCategory(string id, RequestBirdCategoryModel requestBirdCategoryModel)
        {
            var responseModel = _birdCategoryService.UpdateBirdCategory(id, requestBirdCategoryModel);
            return Ok(responseModel);
        }

        [HttpDelete]
        [Route("api/[controller]/DeleteBirdCategory")]
        public IActionResult DeleteBirdCategory(string id) 
        {
            var responseModel = _birdCategoryService.DeleteBirdCategory(id);
            return Ok(responseModel);
        }

    }
}
