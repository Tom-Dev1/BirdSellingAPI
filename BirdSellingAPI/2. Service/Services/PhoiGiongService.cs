using AutoMapper;
using BirdSellingAPI._2._Service.IServices;
using BirdSellingAPI._2._Service.Model;
using BirdSellingAPI._3._Repository.BaseRepository;
using BirdSellingAPI._3._Repository.Data;
using BirdSellingAPI._3._Repository.Repository;
using BirdSellingAPI._4._Core.EnumCore;
using BirdSellingAPI._4._Core.Helper;
using BirdSellingAPI._4._Core.Model.PhoiGiong;
using BirdSellingAPI._4._Core.Model.Product;
using Microsoft.AspNetCore.Hosting;
using Microsoft.OpenApi.Extensions;

namespace BirdSellingAPI._2._Service.Services
{
    public class PhoiGiongService : IPhoiGiongService
    {
        private readonly IMapper _mapper;
        private readonly IRepositoryBase<ProductEntity> _productRepository;
        private readonly IPhoiGiongRepository _phoiGiongRepository;

        public PhoiGiongService(IPhoiGiongRepository phoiGiongRepo,
            IMapper mapper, IRepositoryBase<ProductEntity> productRepository)
        {
            _phoiGiongRepository = phoiGiongRepo;
            _mapper = mapper;
            _productRepository = productRepository;
        }

        public ResponseModel CreatePhoiChim(IWebHostEnvironment webHostEnvironment, RequestPhoiGiongModel requestPhoiGiongModel)
        {
            var productCuaKHEntity = _mapper.Map<ProductEntity>(requestPhoiGiongModel.ChimCuaKhacHang);
            var phoiGiongEntity = new PhoiGiongEntity()
            {
                bird_KH_id = productCuaKHEntity.Id,
                bird_Shop_id = requestPhoiGiongModel.ChimMuonPhoi_id,
                PhoiGiongStatus = _4._Core.EnumCore.PhoiGiongStatus.ChuaXacNhan
            };
            var imageType = TypeProduct.ChimCuaKhachHang.GetDisplayName();
            var imagePath = ImageHandler.UploadImageToFile(webHostEnvironment, requestPhoiGiongModel.ChimCuaKhacHang.imageFiles,
                imageType.ToString(), productCuaKHEntity.Id);
            productCuaKHEntity.image = imagePath;
            var result = _phoiGiongRepository.CreatePhoiGiong(productCuaKHEntity, phoiGiongEntity);
            if (result == false)
            {
                throw new Exception();
            }
            return new ResponseModel
            {
                StatusCode = 200,
            };
        }

        public ResponseModel GetAllPhoiChim()
        {
            var phoiChimList = _mapper.Map<List<ResponsePhoiGiongModel>>(_phoiGiongRepository.Get().ToList());
            var productList = _productRepository.Get().ToList();
            foreach (var item in phoiChimList)
            {
                var bird_KH_Response = productList.Where(x => x.Id == item.bird_KH_id).FirstOrDefault();
                var bird_Shop_Response = productList.Where(x => x.Id == item.bird_Shop_id).FirstOrDefault();
                item.bird_KH = _mapper.Map<ResponseProductModel>(bird_KH_Response);
                item.bird_Shop = _mapper.Map<ResponseProductModel>(bird_Shop_Response);
            }
            return new ResponseModel { StatusCode = 200, Data = phoiChimList };
        }

        public ResponseModel GetChimCungLoaiKhacGioiTinh(string categoryId, bool sex)
        {
            var productList = _productRepository.Get(x => x.category_id == categoryId
            && x.sex != sex).ToList();
            var responseModel = _mapper.Map<List<ResponseProductModel>>(productList);
            return new ResponseModel { StatusCode = 200, Data = responseModel };
        }

        public ResponseModel GetDetail(string phoiGiongId)
        {
            var phoiChim = _mapper.Map<ResponsePhoiGiongModel>(_phoiGiongRepository.
                Get(x => x.Id == phoiGiongId).FirstOrDefault());
            var productList = _productRepository.Get(x => x.Id == phoiChim.bird_KH_id || 
            x.Id == phoiChim.bird_Shop_id).ToList();
            var bird_KH_Response = productList.Where(x => x.Id == phoiChim.bird_KH_id).FirstOrDefault();
            var bird_Shop_Response = productList.Where(x => x.Id == phoiChim.bird_Shop_id).FirstOrDefault();
            phoiChim.bird_KH = _mapper.Map<ResponseProductModel>(bird_KH_Response);
            phoiChim.bird_Shop = _mapper.Map<ResponseProductModel>(bird_Shop_Response);
            return new ResponseModel { StatusCode = 200, Data = phoiChim };
        }

        public ResponseModel GetUserProduct(string userID)
        {
            var productList = _productRepository.Get(x => x.userID == userID).ToList();
            var response = _mapper.Map<List<ResponseProductModel>>(productList);
            return new ResponseModel
            {
                Data = response,
                StatusCode = 200,
            };
        }

        public ResponseModel UpdateTrangThaiPhoiGiong(string phoiGiongId, UpdateTrangThaiPhoiGiongModel updateTrangThaiPhoiGiongModel)
        {
            var updateEntity = _phoiGiongRepository.GetSingle(x => x.Id == phoiGiongId);
            _mapper.Map(updateTrangThaiPhoiGiongModel, updateEntity);
            _phoiGiongRepository.Update(updateEntity);
            return new ResponseModel { StatusCode = 200, Data= updateEntity };
        }
    }
}
