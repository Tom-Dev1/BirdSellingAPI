using BirdSellingAPI._3._Repository.Data;
using BirdSellingAPI._4._Core.Model.Product;

namespace BirdSellingAPI._4._Core.Model.OrderDetail
{
    public class ResponseCartModel
    {
        public string Id { get; set; }

        public string product_id { get; set; }

        public string? order_id { get; set; }

        public decimal? price { get; set; }

        public decimal? quantity { get; set; }

        public string user_id { get; set; }

        public ResponseProductModel Product { get; set; }

    }
}
