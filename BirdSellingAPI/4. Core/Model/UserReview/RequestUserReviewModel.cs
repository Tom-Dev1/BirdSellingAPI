﻿namespace BirdSellingAPI._4._Core.Model.UserReview
{
    public class RequestUserReviewModel
    {
        public string user_id {  get; set; }

        public string bird_id { get; set; }

        public string rating_value { get; set; }

        public string comment { get; set; }
    }
}
