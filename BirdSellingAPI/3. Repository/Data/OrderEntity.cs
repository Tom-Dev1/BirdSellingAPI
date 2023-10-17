using BirdSellingAPI.Entity;
using System.ComponentModel.DataAnnotations.Schema;

namespace BirdSellingAPI._3._Repository.Data
{
    [Table("Order")]
    public class OrderEntity : Entity
    {

        public string user_id;

        public DateTimeOffset order_date {  get; set; }

        public string paymentMenthod_id;

        public string shippingMenthod_id;

        public string orderTotal {  get; set; }

        public  bool orderStatus {  get; set; }

    }
}
