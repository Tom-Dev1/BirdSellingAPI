using System.ComponentModel.DataAnnotations.Schema;

namespace BirdSellingAPI._3._Repository.Data
{
    [Table("PromotionCategory")]
    public class PromotionCategoryEntity : Entity   
    {
        public string birdCategory {  get; set; }

        public string promotionCategory_id { get; set; }

        [ForeignKey(nameof(promotionCategory_id))]
        public string promotionCategory { get; set; }
    }
}
