namespace BirdSellingAPI._4._Core.Model.UserPaymentMenthod
{
    public class RequestUserPaymentModel
    {
        public string user_id { get; set; }

        public string paymentType_id { get; set; }

        public string provide { get; set; }

        public string account_number { get; set; }
        
        public string description { get; set; }
    }
}
