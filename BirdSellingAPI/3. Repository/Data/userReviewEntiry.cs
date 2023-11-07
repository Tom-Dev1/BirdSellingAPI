using System.ComponentModel.DataAnnotations.Schema;

namespace BirdSellingAPI._3._Repository.Data
{
    [Table("UserReview")]
    public class userReviewEntiry : Entity
    {
        public string user_id { get; set; }

        public string bird_id { get; set; }

        public string? rating_value {  get; set; }

        public string? comment { get; set; }



    }
}
