using BirdSellingAPI._2._Service.IServices;
using BirdSellingAPI._4._Core.Model.PhoiGiong;
using BirdSellingAPI._4._Core.Model.Product;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BirdSellingAPI._1._Web
{
    [ApiController]
    public class PhoiGiongController : ControllerBase
    {
        private readonly IPhoiGiongService _phoiGiongService;

        public PhoiGiongController(IPhoiGiongService phoiGiongService)
        {
            _phoiGiongService = phoiGiongService;
        }

        [HttpPost]
        [Route("api/[controller]/Create-Phoi-Chim")]
        public IActionResult CreatePhoiChim(RequestPhoiGiongModel requestPhoiGiongModel)
        {
            var response = _phoiGiongService.CreatePhoiChim(requestPhoiGiongModel);
            return Ok(response);
        }

        [HttpPut]
        [Route("api/[controller]/UpdateTrangThaiPhoiGiong")]
        public IActionResult UpdateTrangThaiPhoiGiong(string phoiGiongId, UpdateTrangThaiPhoiGiongModel updateTrangThaiPhoiGiongModel)
        {
            var response = _phoiGiongService.UpdateTrangThaiPhoiGiong(phoiGiongId, updateTrangThaiPhoiGiongModel);
            return Ok(response);
        }

        [HttpGet]
        [Route("api/[controller]/GetProductOfUser")]
        public IActionResult GetProductOfUser(string userID)
        {
            var response = _phoiGiongService.GetUserProduct(userID);
            return Ok(response);
        }

        [HttpGet]
        [Route("api/[controller]/GetDetailPhoiGiong")]
        public IActionResult GetDetailPhoiGiong(string phoiGiongId)
        {
            var response = _phoiGiongService.GetDetail(phoiGiongId);
            return Ok(response);
        }

        [HttpGet]
        [Route("api/[controller]/GetChimCungLoaiKhacGioiTinh")]
        public IActionResult GetChimCungLoaiKhacGioiTinh(string categoryId, bool Sex)
        {
            var response = _phoiGiongService.GetChimCungLoaiKhacGioiTinh(categoryId, Sex);
            return Ok(response);
        }

        [HttpGet]
        [Route("api/[controller]/GetAllPhoiChim")]
        public IActionResult GetAllPhoiChim()
        {
            var response = _phoiGiongService.GetAllPhoiChim();
            return Ok(response);
        }
    }
}
