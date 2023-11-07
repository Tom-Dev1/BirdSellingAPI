using System.ComponentModel.DataAnnotations.Schema;

namespace BirdSellingAPI._3._Repository.Data
{
    [Table("User")]
    public class UserEntity : Entity 
    {
        public string? userName { get; set; }

        public string? userPassword { get; set; }

        public string? userEmail { get; set; }
        public string? VerifyEmail { get; set; }

        public string? userPhone { get; set; }

        public DateTimeOffset? createdAt { get; set; }

        public string role_id { get; set; }

        public string? AddressLine { get; set; }


        [ForeignKey(nameof(role_id))]
        public RoleEntity Role {  get; set; }

        public bool? isActive { get; set; }
        public virtual ICollection<CartEntity> Carts { get; set; }
        public virtual ICollection<OrderEntity> OrderEntities { get; set; }
    }
}
