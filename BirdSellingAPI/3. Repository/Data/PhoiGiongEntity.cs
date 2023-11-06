namespace BirdSellingAPI._3._Repository.Data
{
    public class PhoiGiongEntity : Entity
    {
        public string? bird_mother_id { get; set; }
        public string? bird_father_id { get; set; }
        public DateTimeOffset? NgayChoPhoi {  get; set; }
        public DateTimeOffset? NgayCoTrung { get; set; }
        public DateTimeOffset? NgayTrungNo {  get; set; }
        public int? SoTrung {  get; set; }
        public int? SoTrungNo { get; set; }
        public int? SoTrungHong { get; set; }
    }
}
