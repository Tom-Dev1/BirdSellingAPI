using System.ComponentModel.DataAnnotations.Schema;

namespace BirdSellingAPI._3._Repository.Data
{
    [Table("BirdCategory")]
    public class BirdCategoryEntity : Entity 
    {
        public string  category_name {  get; set; } 

        public virtual ICollection<ProductEntity> Products { get; set; }

    }
}
