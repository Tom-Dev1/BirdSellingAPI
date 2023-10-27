using BirdSellingAPI._2._Service.IServices;
using BirdSellingAPI._2._Service.Model.BirdCategory;
using BirdSellingAPI._2._Service.Services;
using BirdSellingAPI._4._Core.Model.Promotion;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BirdSellingAPI._1._Web
{
   
    [ApiController]
    public class PromotionController : ControllerBase
    {
        private readonly IPromotionService _promotionService;

        public PromotionController(IPromotionService promotionService) 
        {
            _promotionService = promotionService;
        }
    }
    //[HttpGet]
    //[Route("api/[controller]/GetAllPromotion")]
    //public IActionResult GetAllPromotion()
    //{
    //    var responseModel = _promotionService.GetAll();
    //    return Ok(responseModel);
    //}

}
