using BirdSellingAPI._2._Service.Model;
using BirdSellingAPI._4._Core.Model.Auth;

namespace BirdSellingAPI._2._Service.IServices
{
    public interface IAuthService
    {
        public ResponseModel SignUp(SignUpModel signUpModel);
        public ResponseModel SignIn(SignInModel signInModel);
        public ResponseModel VerifyEmail(string username, string verifyKey);

        //public ResponseModel ForgetPassword(SignInModel signInModel);

    }
}
