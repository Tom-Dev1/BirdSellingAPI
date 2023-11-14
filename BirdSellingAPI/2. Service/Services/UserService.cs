using AutoMapper;
using BirdSellingAPI._2._Service.IServices;
using BirdSellingAPI._2._Service.Model;
using BirdSellingAPI._2._Service.Model.BirdCategory;
using BirdSellingAPI._3._Repository.BaseRepository;
using BirdSellingAPI._3._Repository.Data;
using BirdSellingAPI._4._Core.Model.User;

namespace BirdSellingAPI._2._Service.Services
{
    public class UserService : IUserService
    {
        private readonly IRepositoryBase<UserEntity> _userRepository;
        private readonly IMapper _mapper;

        public UserService(IRepositoryBase<UserEntity> repository, IMapper mapper)
        {
            _userRepository = repository;
            _mapper = mapper;
        }

        //Get ALL
        public ResponseModel GetAll()
        {
            var response = _userRepository.GetAll();
            return new ResponseModel
            {
                Data = response,
                MessageError = "",
                StatusCode = StatusCodes.Status200OK
            };
        }
        //GetID
        public ResponseModel GetSingle(string id)
        {
            var userEntity = _userRepository.GetSingle(x => x.Id.Equals(id));
            var responseUserModel = _mapper.Map<ResponseUserModel>(userEntity);
            return new ResponseModel
            {
                Data = userEntity,
                MessageError = "",
                StatusCode = StatusCodes.Status200OK
            };
        }
        //Update
        public ResponseModel UpdateUser(string id, RequestUserModel requestUserModel)
        {
            var userEntity = _userRepository.GetSingle(x => id.Equals(x.Id));
            if (userEntity == null)
            {
                return new ResponseModel
                {
                    MessageError = "Khong tim thay",
                    StatusCode = StatusCodes.Status404NotFound
                };
            }
            _mapper.Map(requestUserModel, userEntity);
            _userRepository.Update(userEntity);
            return new ResponseModel
            {
                StatusCode = StatusCodes.Status200OK
            };
        }
        //Delete bY ID
        public ResponseModel DeleteUser(string id)
        {
            var userEntity = _userRepository.GetSingle(x => x.Id.Equals(id));
            if (userEntity == null)
            {
                return new ResponseModel
                {
                    MessageError = "Khong tim thay",
                    StatusCode = StatusCodes.Status404NotFound
                };
            }
            _userRepository.Delete(userEntity);
            return new ResponseModel
            {
                StatusCode = StatusCodes.Status200OK
            };
        }

    }
}
