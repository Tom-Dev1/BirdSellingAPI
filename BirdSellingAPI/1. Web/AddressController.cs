using BirdSellingAPI._2._Service.IServices;
using BirdSellingAPI._2._Service.Model.BirdCategory;
using BirdSellingAPI._2._Service.Services;
using BirdSellingAPI._4._Core.Model.Address;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BirdSellingAPI._1._Web
{
    
    [ApiController]
    public class AddressController : ControllerBase
    {
        private readonly IAddressService _addressService;

        public AddressController(IAddressService addressService)
        {
            _addressService = addressService;
        }
        [HttpPost]
        [Route("api/[controller]/CreateAddress")]
        public IActionResult CreacteAddress(RequestAddressModel requestAddressModel)
        {
            var responseModel = _addressService.CreateAddress(requestAddressModel);
            return Ok(responseModel);
        }
        [HttpGet]
        [Route("api/[controller]/GetAll")]
        public IActionResult GetAllBirdCategory()
        {
            var responseModel = _addressService.GetAll();
            return Ok(responseModel);
        }
        [HttpGet]
        [Route("api/[controller]/GetSingleID")]
        public IActionResult GetSingleID(string id)
        {
            var responseModel  =  _addressService.GetSingleID(id);
            return Ok(responseModel);
        }
        [HttpPut]
        [Route("api/[controller]/UpdateAddress")]
        public IActionResult UpdateAddress(string id, RequestAddressModel requestAddressModel)
        {
            var responseModel = _addressService.UpdateAddress(id, requestAddressModel);
            return Ok(responseModel);
        }
        [HttpDelete]
        [Route("api/[controller]/DeleteAddress")]
        public IActionResult DeleteAddress(string id)
        {
            var responseModel = _addressService.DeleteAddress(id);
            return Ok(responseModel);
        }

    }
}
