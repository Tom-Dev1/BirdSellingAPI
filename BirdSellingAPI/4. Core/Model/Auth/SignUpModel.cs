using BirdSellingAPI._3._Repository.Data;
using System.ComponentModel.DataAnnotations.Schema;

namespace BirdSellingAPI._4._Core.Model.Auth
{
    public class SignUpModel
    {
        public string userName { get; set; }

        public string userPassword { get; set; }

        public string userEmail { get; set; }

        public string? userPhone { get; set; }

        public string role_id { get; set; }

        public string? AddressLine { get; set; }
    }
}
