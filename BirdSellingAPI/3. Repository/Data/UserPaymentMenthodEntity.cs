using System.ComponentModel.DataAnnotations.Schema;

namespace BirdSellingAPI._3._Repository.Data
{
    [Table("UserPaymentMenthod")]
    public class UserPaymentMenthodEntity : Entity
    {
        public string name { get; set; }
    }
}
