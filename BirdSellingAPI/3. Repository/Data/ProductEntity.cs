using BirdSellingAPI._4._Core.EnumCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace BirdSellingAPI._3._Repository.Data
{
    [Table("Product")]
    public class ProductEntity : Entity
    {
        public string category_id { get; set; }

        public string image {  get; set; }
        [Column(TypeName = "decimal(38,4)")]
        public decimal? price { get; set; }

        public string? name { get; set; }

        public bool? sex { get; set; }

        public string? description { get; set; }

        public string? bird_mother_id { get; set; }

        public string? bird_father_id { get; set; }
        public int? Discount { get; set; }

        public TypeProduct? TypeProduct { get; set; }
        public StatusProduct statusProduct { get; set; }

        public DateTimeOffset day_of_birth { get; set; }
        [ForeignKey(nameof(category_id))]
        public BirdCategoryEntity BirdCategory { get; set; }

        public virtual ICollection<CartEntity> Carts { get; set; }
    }
}
