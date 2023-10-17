using System.ComponentModel.DataAnnotations.Schema;

namespace BirdSellingAPI._3._Repository.Data
{
    [Table("Address")]
    public class AddressEntity : Entity
    {
        public string AddressLine1 { get; set; } = null!;

        public string City { get; set; } = null!;

        public string Region { get; set; } = null!;

        public string Country { get; set; } = null!;
    }
}
