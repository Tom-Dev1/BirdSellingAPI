using System.ComponentModel.DataAnnotations;

namespace BirdSellingAPI._3._Repository.Data
{
    public class Entity
    {
        protected Entity()
        {
            Id = Guid.NewGuid().ToString("N");
            CreatedTime = LastUpdatedTime = DateTime.Now;
        }
        [Key]
        public string Id { get; set; }
        public DateTimeOffset CreatedTime { get; set; }
        public DateTimeOffset LastUpdatedTime { get; set; }
        public DateTimeOffset? DeletedTime { get; set; }

    }
}
