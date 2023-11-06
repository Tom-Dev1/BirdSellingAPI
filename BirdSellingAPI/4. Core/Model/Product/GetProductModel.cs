using BirdSellingAPI._4._Core.EnumCore;
using System.ComponentModel;

namespace BirdSellingAPI._4._Core.Model.Product
{
    public class GetProductModel
    {
        public string? category_id { get; set; }
        public string? name { get; set; } 
        public bool? sex { get; set; }
        public TypeProduct? TypeProduct { get; set; }
        public decimal? priceFrom { get; set; }
        public decimal? priceTo { get; set; }
        public StatusProduct statusProduct { get; set; }
        public GetProductModel()
        {
            name = "";
            priceFrom = 0;
            priceTo = Int64.MaxValue;
        }

    }
}
