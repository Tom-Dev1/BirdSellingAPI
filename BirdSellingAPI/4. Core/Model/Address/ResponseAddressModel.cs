namespace BirdSellingAPI._4._Core.Model.Address
{
    public class ResponseAddressModel
    {
        public string Id;
        public string AddressLine { get; set; }

        public string City { get; set; }

        public string Region { get; set; }

        public string Country { get; set; }
    }
}
