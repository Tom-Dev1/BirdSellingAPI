using BirdSellingAPI._4._Core.EnumCore;
using BirdSellingAPI._4._Core.Model.Product;

namespace BirdSellingAPI._4._Core.Model.PhoiGiong
{
    public class ResponsePhoiGiongModel
    {
        public string Id { get; set; }
        public string? bird_KH_id { get; set; }
        public string? bird_Shop_id { get; set; }
        public DateTimeOffset? NgayChoPhoi { get; set; }
        public DateTimeOffset? NgayCoTrung { get; set; }
        public DateTimeOffset? NgayTrungNo { get; set; }
        public int? SoTrung { get; set; }
        public int? SoTrungNo { get; set; }
        public int? SoTrungHong { get; set; }
        public int? SoChimGiao { get; set; }
        public PhoiGiongStatus PhoiGiongStatus { get; set; }
        public decimal? GiaTien { get; set; }
        public decimal? DaThanhToan { get; set; }
        public decimal? ConLai { get; set; }
        public ResponseProductModel? bird_KH { get; set; }
        public ResponseProductModel? bird_Shop { get; set; }
    }
}
