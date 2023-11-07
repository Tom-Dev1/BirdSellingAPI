using BirdSellingAPI._4._Core.EnumCore;

namespace BirdSellingAPI._4._Core.Model.Order
{
    public class ResponseOrderModel
    {
        public string Id { get; set; }

        public string user_id { get; set; }

        public DateTimeOffset order_date { get; set; }

        public string paymentMenthod_id { get; set; }

        public string shippingMenthod_id { get; set; }

        public string? orderTotal { get; set; }

        public OrderStatus? orderStatus { get; set; }
    }
}
