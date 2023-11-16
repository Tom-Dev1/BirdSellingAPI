using BirdSellingAPI._4._Core.EnumCore;

namespace BirdSellingAPI._4._Core.Model.Product
{
    public class ResponseProductModel
    {
        public string Id { get; set; }
        public string category_id { get; set; }

        public string image { get; set; }

        public decimal price { get; set; }

        public string name { get; set; }

        public bool sex { get; set; }

        public string description { get; set; }

        public string bird_mother_id { get; set; }

        public string bird_father_id { get; set; }
        public StatusProduct statusProduct { get; set; }
        public int? Discount { get; set; }
        public TypeProduct? TypeProduct { get; set; }
        public DateTimeOffset day_of_birth { get; set; }
    }
}
