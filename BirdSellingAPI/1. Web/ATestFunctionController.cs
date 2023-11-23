using BirdSellingAPI._3._Repository.BaseRepository;
using BirdSellingAPI._3._Repository.Data;
using BirdSellingAPI._3._Repository.Repository;
using BirdSellingAPI._4._Core.EnumCore;
using BirdSellingAPI._4._Core.Helper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.OpenApi.Extensions;

namespace BirdSellingAPI._1._Web
{
    [Route("api/[controller]")]
    [ApiController]
    public class ATestFunctionController : ControllerBase
    {
        private readonly IRepositoryBase<BirdCategoryEntity> _birdCateGoryRepository;
        private readonly IWebHostEnvironment _webHost;

        public ATestFunctionController(IRepositoryBase<BirdCategoryEntity> birdCategoryRepository
            , IWebHostEnvironment webHostEnvironment)
        {
            _webHost = webHostEnvironment;
            _birdCateGoryRepository = birdCategoryRepository;
        }

        //[HttpPost]
        //public IActionResult UploadFile(IFormFile file)
        //{
        //    var typeProduct = TypeProduct.Chim.GetDisplayName();
        //    var filePath = ImageHandler.UploadImageToFile(_webHost, file, typeProduct, Guid.NewGuid().ToString("N"));
        //    return Ok(filePath);
        //}

        //[HttpGet]
        //public IActionResult LoadFile(string filePath)
        //{
        //    var imageBytes = ImageHandler.loadFile(_webHost, filePath);
        //    string contentType = "image/jpeg";
        //    var testObject = new BirdCategoryEntity()
        //    {
        //        category_name = Guid.NewGuid().ToString(),
        //    };
        //    var returnObject = new ATestObject()
        //    {
        //        imageBase64 = Convert.ToBase64String(imageBytes),
        //        BirdCategoryEntity = testObject
        //    };
        //    return Ok(returnObject);
        //}
    }
}
