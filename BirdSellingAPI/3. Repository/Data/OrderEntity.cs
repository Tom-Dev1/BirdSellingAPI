using BirdSellingAPI._4._Core.EnumCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace BirdSellingAPI._3._Repository.Data
{
    [Table("Order")]
    public class OrderEntity : Entity
    {
        public DateTimeOffset order_date {  get; set; }

        public string? paymentMenthod_id { get; set; }

        [Column(TypeName = "decimal(38,4)")]
        public decimal? orderTotal {  get; set; }

        public OrderStatus? orderStatus {  get; set; }

        public string Address { get; set; }

        [ForeignKey(nameof(paymentMenthod_id))]
        public UserPaymentMenthodEntity paymentMenthod { get; set; }

        public string user_id { get; set; }
        [ForeignKey(nameof(user_id))]
        public UserEntity User { get; set; }

        public virtual ICollection<OrderEntity> orderEntities { get; set; }
    }
}
