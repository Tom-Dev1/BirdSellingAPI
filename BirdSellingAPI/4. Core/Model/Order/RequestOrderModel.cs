namespace BirdSellingAPI._4._Core.Model.Order
{
    public class RequestOrderModel
    {
        public string user_id;

        public DateTimeOffset order_date { get; set; }

        public string paymentMenthod_id;

        public string shippingMenthod_id;

        public string orderTotal { get; set; }

        public bool orderStatus { get; set; }
    }
}
