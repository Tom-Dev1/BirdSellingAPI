namespace BirdSellingAPI._3._Repository.Data
{
    public class EggEntity : Entity
    {
        public string bird_father_id;
        public string bird_father_name { get; set; }
        public DateTimeOffset NgaySinh {  get; set; }
    }
}
