using BirdSellingAPI._3._Repository.Data;
using BirdSellingAPI._4._Core.EnumCore;
using BirdSellingAPI._4._Core.Model.OrderDetail;
using BirdSellingAPI._4._Core.Model.User;
using System.ComponentModel.DataAnnotations.Schema;

namespace BirdSellingAPI._4._Core.Model.Order
{
    public class ResponseOrderModel
    {
        public string Id { get; set; }

        public string user_id { get; set; }

        public DateTimeOffset order_date { get; set; }

        public string paymentMenthod_id { get; set; }

        public string shippingMenthod_id { get; set; }

        public string? orderTotal { get; set; }

        public OrderStatus? orderStatus { get; set; }

        public ResponseUserModel? User { get; set; }
        public virtual ICollection<ResponseCartModel> Carts { get; set; }

        public string? Address { get; set; }
    }
}
