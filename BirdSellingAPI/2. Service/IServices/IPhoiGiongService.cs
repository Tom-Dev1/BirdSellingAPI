using BirdSellingAPI._2._Service.Model;
using BirdSellingAPI._4._Core.EnumCore;
using BirdSellingAPI._4._Core.Model.PhoiGiong;

namespace BirdSellingAPI._2._Service.IServices
{
    public interface IPhoiGiongService
    {
        public ResponseModel GetChimCungLoaiKhacGioiTinh(string categoryId, bool sex);
        public ResponseModel UpdateTrangThaiPhoiGiong (string phoiGiongId, UpdateTrangThaiPhoiGiongModel updateTrangThaiPhoiGiongModel);
        public ResponseModel GetUserProduct (string userID);
        public ResponseModel GetAllPhoiChim();
        public ResponseModel GetDetail(string phoiGiongId);
        public ResponseModel CreatePhoiChim(RequestPhoiGiongModel requestPhoiGiongModel);
    }
}
