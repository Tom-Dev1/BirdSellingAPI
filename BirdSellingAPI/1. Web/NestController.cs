using BirdSellingAPI._2._Service.IServices;
using BirdSellingAPI._2._Service.Model.BirdCategory;
using BirdSellingAPI._2._Service.Services;
using BirdSellingAPI._4._Core.Model.Nest;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BirdSellingAPI._1._Web
{
    
    [ApiController]
    public class NestController : ControllerBase
    {
        private readonly INestService _nestService;

        public NestController(INestService nestService) 
        {
            _nestService =  nestService;
        }

        [HttpPost]
        [Route("api/[controller]/CreateNest")]
        public IActionResult CreateNest (RequestNestModel requestNestModel)
        {
            var responseModel = _nestService.CreateNest(requestNestModel);
            return Ok(responseModel);   
        }
        [HttpGet]
        [Route("api/[controller]/GetAllNest")]
        public IActionResult GetAllNest()
        {
            var responseModel = _nestService.GetAll();
            return Ok(responseModel);
        }
        [HttpGet]
        [Route("api/[controller]/GetSingleID")]
        public IActionResult GetSingleID(string id)
        {
            var responseModel = _nestService.GetSingle(id);
            return Ok(responseModel);

        }
        [HttpPut]
        [Route("api/[controller]/UpdateNest")]
        public IActionResult UpdateNest(string id, RequestNestModel requestNestModel)
        {
            var responseModel = _nestService.UpdateNest(id, requestNestModel);
            return Ok(responseModel);
        }

        [HttpDelete]
        [Route("api/[controller]/DeleteNest")]
        public IActionResult DeleteNest(string id)
        {
            var responseModel = _nestService.DeleteNest(id);
            return Ok(responseModel);
        }

    }
}
