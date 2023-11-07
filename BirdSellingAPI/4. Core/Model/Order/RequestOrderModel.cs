using BirdSellingAPI._3._Repository.Data;
using BirdSellingAPI._4._Core.EnumCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace BirdSellingAPI._4._Core.Model.Order
{
    public class RequestOrderModel
    {
        public List<string> listIDCarts {  get; set; }
        public string user_id { get; set; }

        public string? paymentMenthod_id { get; set; }

        public string Address { get; set; }
    }
}
