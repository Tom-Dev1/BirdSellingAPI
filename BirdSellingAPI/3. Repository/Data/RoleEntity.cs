using System.ComponentModel.DataAnnotations.Schema;

namespace BirdSellingAPI._3._Repository.Data
{
    [Table("Role")]
    public class RoleEntity : Entity

    {
        public string? role_name { get; set; }

        public virtual ICollection<UserEntity> UserEntities { get; set;}
    }
    
    

}
