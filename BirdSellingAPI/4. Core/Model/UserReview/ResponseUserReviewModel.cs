namespace BirdSellingAPI._4._Core.Model.UserReview
{
    public class ResponseUserReviewModel
    {
        public string Id;

        public string user_id;

        public string bird_id;

        public string rating_value { get; set; }

        public string comment { get; set; }
    }
}
