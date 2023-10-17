using System.ComponentModel.DataAnnotations.Schema;

namespace BirdSellingAPI._3._Repository.Data
{
    [Table("UserPaymentMenthod")]
    public class UserPaymentMenthodEntity
    {
        public string user_id;

        public string paymentType_id;

        public string provide { get; set; }

        public string account_number {  get; set; }

        public string description { get; set; }




    }
}
