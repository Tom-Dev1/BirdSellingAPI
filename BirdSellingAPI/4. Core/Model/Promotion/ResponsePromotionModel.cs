namespace BirdSellingAPI._4._Core.Model.Promotion
{
    public class ResponsePromotionModel
    {
        public string Id;
        public string name { get; set; }

        public string description { get; set; }

        public DateTimeOffset start_day { get; set; }

        public DateTimeOffset end_day { get; set; }
    }
}
