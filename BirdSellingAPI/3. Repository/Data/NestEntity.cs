using System.ComponentModel.DataAnnotations.Schema;

namespace BirdSellingAPI._3._Repository.Data
{
    [Table("Nest")]
    public class NestEntity : Entity
    {
        public string? name { get; set; };
        public string? image { get; set; }

    }
}
