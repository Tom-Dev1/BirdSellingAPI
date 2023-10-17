using System.ComponentModel.DataAnnotations.Schema;

namespace BirdSellingAPI._3._Repository.Data
{
    [Table("Bird")]
    public class BirdEntity : Entity
    {

        public string category_id { get; set; }
        public string image {  get; set; }
        public decimal price { get; set; }
        public string name { get; set; }
        public bool sex { get; set; }
        public string description { get; set; }
        public string bird_mother_id { get; set; }
        public string bird_father_id { get; set; }

        [ForeignKey(nameof(category_id))]
        public BirdCategoryEntity BirdCategory { get; set; }

    }
}
