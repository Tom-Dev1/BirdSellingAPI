using System.ComponentModel.DataAnnotations.Schema;

namespace BirdSellingAPI._3._Repository.Data
{
    [Table("ShippingMenthod")]
    public class shippingMenthodEntity : Entity
    {
        public string name { get; set; }

    }
}
