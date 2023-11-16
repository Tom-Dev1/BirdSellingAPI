using AutoMapper;
using BirdSellingAPI._2._Service.IServices;
using BirdSellingAPI._2._Service.Model;
using BirdSellingAPI._2._Service.Model.BirdCategory;
using BirdSellingAPI._3._Repository.BaseRepository;
using BirdSellingAPI._3._Repository.Data;
using BirdSellingAPI._4._Core.Model.Product;
using Microsoft.AspNetCore.Mvc;

namespace BirdSellingAPI._1._Web
{
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productSerivce;
        //private readonly object _productRepository;

        public ProductController(IProductService service) 
        {
            _productSerivce = service;
        }

        [HttpPost]
        [Route("api/[controller]/CreateProduct")]
        public IActionResult CreateProduct (RequestProductModel requestProductModel)
        {
            var response = _productSerivce.CreateProduct(requestProductModel);
            return Ok(response);
        }

        [HttpGet]
        [Route("api/[controller]/GetProduct")]
        public IActionResult GetProduct([FromQuery]GetProductModel getProductModel)
        {
            var response = _productSerivce.GetListProduct(getProductModel);
            return Ok(response);
        }
        [HttpGet]
        [Route("api/[controller]/GetProductByID/{id}")]
        public IActionResult GetProductByID(string id)
        {
            var response = _productSerivce.GetProductByID(id);
            return Ok(response);
        }

        [HttpDelete]
        [Route("api/[controller]/DeleteProduct/{id}")]
        public IActionResult DeleteProduct(string id)
        {
            var response = _productSerivce.DeleteProduct(id);
            return Ok(response);
        }


        [HttpPut]
        [Route("api/[controller]/UpdateProduct/{id}")]
        public IActionResult UpdateProduct(string id, RequestProductModel requestProductModel)
        {
            var response = _productSerivce.UpdateProduct(id, requestProductModel);
            return Ok(response);
        }

        //[HttpPut]
        //[Route("api/[controller]/UpdateProduct")]
        //public IActionResult UpdateProduct(string id, RequestProductModel requestProductModel)
        //{
        //    var response = _productSerivce.Update;
        //    return Ok(response);
        //}


        //[HttpGet]
        //[Route("api/[controller]/GetAll")]
        //public IActionResult GetAll()
        //{
        //    var responseModel = _productRepository.GetAll();
        //    var response = new ResponseModel()
        //    {
        //        MessageError = "Loi Khong tai duoc",
        //        Data = responseModel,
        //        StatusCode = StatusCodes.Status200OK
        //    };
        //    return Ok(response);
        //}

        //[HttpGet]
        //[Route("api/[controller]/GetByName")]
        //public IActionResult GetByName(string name)
        //{
        //    var responseModel = _productRepository.Get(x => x.category_name == name);
        //    return Ok(responseModel);
        //}

        //[HttpPost]
        //[Route("api/[controller]/Create")]
        //public IActionResult Create(RequestBirdCategoryModel requestBirdCategoryModel)
        //{
        //    var productEntity = _mapper.Map<BirdCategoryEntity>(requestBirdCategoryModel);
        //    _productRepository.Create(productEntity);
        //    return Ok();
        //}
        //[HttpPut]
        //[Route("api/[controller]/Update")]
        //public IActionResult Update(string id, TestRequestModel testRequestModel)
        //{
        //    var productEntity = _productRepository.GetSingle(x => x.Id == id);
        //    productEntity.category_name = testRequestModel.name;
        //    _productRepository.Update(productEntity);
        //    return Ok();
        //}

        //[HttpPut]
        //[Route("api/[controller]/Delete")]
        //public IActionResult Delete(string id)
        //{
        //    var productEntity = _productRepository.GetSingle(x => x.Id == id);
        //    _productRepository.Delete(productEntity);
        //    return Ok();
        //}
    }
}
