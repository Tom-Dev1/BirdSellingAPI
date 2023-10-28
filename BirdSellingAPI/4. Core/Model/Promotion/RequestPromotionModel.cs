namespace BirdSellingAPI._4._Core.Model.Promotion
{
    public class RequestPromotionModel
    {
        public string name { get; set; }

        public string description { get; set; }

        public DateTimeOffset start_day { get; set; }

        public DateTimeOffset end_day { get; set; }
    }
}
