using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BirdSellingAPI._3._Repository.Data
{
    [Table("OrderDetail")]
    public class OrderDetail : Entity
    {
       //foreign key for product
        public string product_id;
       
        public string order_id;

        public decimal price;

        public decimal quantity;

        public string user_id;

        public string nest_id;

        [ForeignKey(nameof(nest_id))]
        public NestEntity nest {  get; set; }
    }
}
