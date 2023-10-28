using System.ComponentModel.DataAnnotations.Schema;

namespace BirdSellingAPI._3._Repository.Data
{
    [Table("PromotionCategory")]
    public class PromotionCategoryEntity : Entity   
    {
        public string birdCategory {  get; set; }

        public string promotion_id { get; set; }

        [ForeignKey(nameof(promotion_id))]
        public string promotion { get; set; }
    }
}
