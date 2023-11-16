using BirdSellingAPI._3._Repository.Data;
using BirdSellingAPI._4._Core.Model.User;

namespace BirdSellingAPI._4._Core.Model.Auth
{
    public class ResponseTokenModel
    {
        public string Token { get; set; }
        public string RefreshToken { get; set; }
        public ResponseUserModel ResponseUserModel { get; set; }
    }
}
