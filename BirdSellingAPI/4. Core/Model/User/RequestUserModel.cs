namespace BirdSellingAPI._4._Core.Model.User
{
    public class RequestUserModel
    {
        public string? userName { get; set; }

        public string? userPassword { get; set; }

        public string? userEmail { get; set; }

        public string? userPhone { get; set; }

        public DateTimeOffset createdAt { get; set; }

        public string role_id { get; set; }

        public string? AddressLine { get; set; }
    }
}
