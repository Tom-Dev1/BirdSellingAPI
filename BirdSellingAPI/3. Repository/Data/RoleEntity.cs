namespace BirdSellingAPI._3._Repository.Data
{
    public class RoleEntity : Entity

    {
        public string role_name { get; set; }

        public virtual ICollection<RoleEntity> roles { get; set;}
    }
    
    

}
