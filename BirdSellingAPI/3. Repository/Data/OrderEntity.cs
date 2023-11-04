using BirdSellingAPI._4._Core.EnumCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace BirdSellingAPI._3._Repository.Data
{
    [Table("Order")]
    public class OrderEntity : Entity
    {

        public string user_id;

        public DateTimeOffset order_date {  get; set; }

        public string paymentMenthod_id { get; set; }

        public string shippingMenthod_id { get; set; }

        public string? orderTotal {  get; set; }

        public OrderStatus? orderStatus {  get; set; }


        [ForeignKey(nameof(shippingMenthod_id))]
        public shippingMenthodEntity shippingMenthodEntity { get; set; }

    }
}
