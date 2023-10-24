using System.ComponentModel.DataAnnotations.Schema;

namespace BirdSellingAPI._3._Repository.Data
{
    [Table("UserReview")]
    public class userReviewEntiry : Entity
    {
        public string user_id;

        public string bird_id;

        public string? rating_value {  get; set; }

        public string? comment { get; set; }



    }
}
