using BirdSellingAPI._3._Repository.BaseRepository;
using BirdSellingAPI._3._Repository.Data;
using BirdSellingAPI._4._Core.Model.Auth;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;

namespace BirdSellingAPI._4._Core.Helper
{
    public class GenerateToken
    {
        private readonly IConfiguration _configuration;
        private readonly IRepositoryBase<UserRefreshToken> _userRefreshTokenRepository;

        public GenerateToken(IConfiguration configuration, IRepositoryBase<UserRefreshToken> repositoryBase) 
        {
            _configuration = configuration;
            _userRefreshTokenRepository = repositoryBase;
        }
        public ResponseTokenModel GenerateTokenModel(UserEntity userEntity)
        {
            var jwtTokenHandler = new JwtSecurityTokenHandler ();
            var secretKeyBytes = Encoding.UTF8.GetBytes(_configuration["JWT:Secret"]);
            var tokenDescription = new SecurityTokenDescriptor
            {
                Audience = _configuration["JWT:ValidAudience"],
                Issuer = _configuration["JWT:ValidIssuer"],
                Subject = new ClaimsIdentity(new[]
                {
                    new Claim ("username", userEntity.userName),
                    new Claim (JwtRegisteredClaimNames.Email, userEntity.userEmail),
                    new Claim (JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                    new Claim (ClaimTypes.Role, userEntity.Role.role_name),
                }),
                IssuedAt = DateTime.Now,
                Expires = DateTime.Now.AddDays(1),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(secretKeyBytes),
                SecurityAlgorithms.HmacSha256Signature),
            };
            var Token = jwtTokenHandler.CreateToken(tokenDescription);
            var accessToken = jwtTokenHandler.WriteToken(Token);
            var refreshToken = RefreshToken();
            var tokenEntity = new UserRefreshToken
            {
                User_Id = userEntity.Id,
                RefreshToken = refreshToken,
                JwtId = Token.Id,
                isUsed = false,
                CreateTime = DateTime.Now,
                ExpireTime = DateTime.Now.AddMonths(6),
            };
            _userRefreshTokenRepository.Create(tokenEntity);
            return new ResponseTokenModel
            {
                Token = accessToken,
                RefreshToken = refreshToken,
            };
            
        }

        public string RefreshToken()
        {
            var random = new byte[32];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(random);
                return Convert.ToBase64String(random);
            };
        }

    }
}
