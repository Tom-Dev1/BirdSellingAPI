using System.ComponentModel.DataAnnotations.Schema;

namespace BirdSellingAPI._3._Repository.Data
{
    [Table("Promotion")]
    public class PromotionEntity : Entity
    {
        public string? name { get; set; }

        public string? description { get; set; }

        public DateTimeOffset start_day { get; set; }

        public DateTimeOffset end_day { get; set; }

        public virtual ICollection<PromotionCategoryEntity> PromotionCategory { get; set; }

    }
}
