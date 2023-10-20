using BirdSellingAPI._3._Repository.BaseRepository;
using BirdSellingAPI._3._Repository.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BirdSellingAPI._1._Web
{
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IRepositoryBase<BirdCategoryEntity> _productRepository;

        public ProductController(IRepositoryBase<BirdCategoryEntity> repository)
        {
            _productRepository = repository;
        }

        [HttpGet]
        [Route("api/[controller]/GetAll")]
        public IActionResult GetAll()
        {
            var responseModel = _productRepository.GetAll();
            return Ok(responseModel);
        }

        [HttpGet]
        [Route("api/[controller]/GetByName")]
        public IActionResult GetByName(string name)
        {
            var responseModel = _productRepository.Get(x => x.category_name == name);
            return Ok(responseModel);
        }

        [HttpPost]
        [Route("api/[controller]/Create")]
        public IActionResult Create(TestRequestModel testRequestModel)
        {
            var productEntity = new BirdCategoryEntity()
            {
                category_name = testRequestModel.name,
            };
            _productRepository.Create(productEntity);
            return Ok();
        }
        [HttpPut]
        [Route("api/[controller]/Update")]
        public IActionResult Update(string id, TestRequestModel testRequestModel)
        {
            var productEntity = _productRepository.GetSingle(x => x.Id == id);
            productEntity.category_name = testRequestModel.name;
            _productRepository.Update(productEntity);
            return Ok();
        }

        [HttpPut]
        [Route("api/[controller]/Delete")]
        public IActionResult Delete(string id)
        {
            var productEntity = _productRepository.GetSingle(x => x.Id == id);
            _productRepository.Delete(productEntity);
            return Ok();
        }
    }
}
