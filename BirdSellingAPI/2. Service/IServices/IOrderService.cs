using BirdSellingAPI._2._Service.Model;
using BirdSellingAPI._4._Core.EnumCore;
using BirdSellingAPI._4._Core.Model.Order;

namespace BirdSellingAPI._2._Service.IServices
{
    public interface IOrderService
    {
        public ResponseModel CreateOrder(RequestOrderModel requestOrderModel);
        public ResponseModel GetSingle(string id);
        public ResponseModel GetAll();
        public ResponseModel UpdateStatusOrder(string orderid, OrderStatus orderStatus);
        //public ResponseModel UpdateDaXacNhan(string orderID);
        //public ResponseModel UpdateHetHang(string orderID);
        //public ResponseModel UpdateHuyDon(string orderID);
        //public ResponseModel UpdateHoanTraHang(string orderID);
        //public ResponseModel UpdateDangVanChuyen(string orderID);
        //public ResponseModel UpdateDaThanhToan(string orderID);
    }
}
