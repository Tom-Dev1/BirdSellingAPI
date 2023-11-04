namespace BirdSellingAPI._4._Core.Model.OrderDetail
{
    public class RequestCartModel
    {
        public string product_id { get; set; }

        public string? order_id { get; set; }

        public decimal? quantity { get; set; }

        public string user_id { get; set; }
    }
}
