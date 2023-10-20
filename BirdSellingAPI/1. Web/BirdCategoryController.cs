using BirdSellingAPI._2._Service.IServices;
using BirdSellingAPI._2._Service.Model.BirdCategory;
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
        [Route("api/[controller]/GetByName")]
        public IActionResult GetAllBirdCategory(string name)
        {
            var responseModel = _birdCategoryService.GetBirdCategoryByName(name);
            return Ok(responseModel);
        }
    }
}
