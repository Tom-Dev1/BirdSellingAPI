using AutoMapper;
using BirdSellingAPI._2._Service.IServices;
using BirdSellingAPI._2._Service.Model;
using BirdSellingAPI._3._Repository.BaseRepository;
using BirdSellingAPI._3._Repository.Data;
using BirdSellingAPI._4._Core.Helper;
using BirdSellingAPI._4._Core.Model.Auth;

namespace BirdSellingAPI._2._Service.Services
{
    public class AuthService : IAuthService
    {
        private readonly IRepositoryBase<UserEntity> _userRepository;
        private readonly IMapper _mapper;
        private readonly GenerateToken _generateTokenRepository;

        public AuthService(IRepositoryBase<UserEntity> repositoryBase, IMapper mapper, GenerateToken generateToken)
        {
            _userRepository = repositoryBase;
            _mapper = mapper;
            _generateTokenRepository = generateToken;

        }

        public ResponseModel SignIn(SignInModel signInModel)
        {
            var userLogin = _userRepository.GetSingle(x => x.userName.Equals(signInModel.userName) &&
            x.userPassword.Equals(signInModel.userPassword), x => x.Role);

            if (userLogin == null)
            {
                return new ResponseModel
                {
                    MessageError = "Tài khoản hoặc mật khẩu không tồn tại",
                };
            }
            var Token = _generateTokenRepository.GenerateTokenModel(userLogin);
            return new ResponseModel
            {
                Data = Token,
                StatusCode = 200,
            };

        }

        public ResponseModel SignUp(SignUpModel signUpModel)
        {
            var userEntity = _mapper.Map<UserEntity>(signUpModel);
            var existUserSignUp = _userRepository.GetSingle(x => x.userName.Equals(signUpModel.userName));
            if (existUserSignUp != null)
            {
                return new ResponseModel
                {
                    MessageError = "Username đã tồn tại",
                    StatusCode = StatusCodes.Status400BadRequest
                };
            }
            _userRepository.Create(userEntity);
            return new ResponseModel
            {
                Data = userEntity,
                MessageError = "",
                StatusCode = StatusCodes.Status200OK
            };
        }
    }
}
