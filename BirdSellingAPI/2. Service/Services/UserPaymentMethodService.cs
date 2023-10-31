using AutoMapper;
using BirdSellingAPI._2._Service.IServices;
using BirdSellingAPI._2._Service.Model.BirdCategory;
using BirdSellingAPI._2._Service.Model;
using BirdSellingAPI._3._Repository.BaseRepository;
using BirdSellingAPI._3._Repository.Data;
using BirdSellingAPI._4._Core.Model.UserPaymentMenthod;

namespace BirdSellingAPI._2._Service.Services
{
    public class UserPaymentMethodService : IUserPaymentMethodService
    {
        private readonly IRepositoryBase<UserPaymentMenthodEntity> _userPaymentMenthodRepository;
        private readonly IMapper _mapper;

        public UserPaymentMethodService(IRepositoryBase<UserPaymentMenthodEntity> repositoryBase, IMapper mapper) 
        {
            _userPaymentMenthodRepository = repositoryBase;
            _mapper = mapper;
        }

        //Create
        public ResponseModel CreateUserPaymentMethod(RequestUserPaymentModel entity)
        {
            var userPaymentMethodEntity = _mapper.Map<UserPaymentMenthodEntity>(entity);
            _userPaymentMenthodRepository.Create(userPaymentMethodEntity);
            return new ResponseModel
            {
                Data = userPaymentMethodEntity,
                MessageError = "",
                StatusCode = StatusCodes.Status200OK
            };
        }
        //GetID
        public ResponseModel GetSingle(string id)
        {
            var userPaymentMethodEntity = _userPaymentMenthodRepository.GetSingle(x => x.Id.Equals(id));
            var responseBirdCategoryModel = _mapper.Map<ResponseUserPaymentModel>(userPaymentMethodEntity);
            return new ResponseModel
            {
                Data = userPaymentMethodEntity,
                MessageError = "",
                StatusCode = StatusCodes.Status200OK
            };
        }
        //Update
        public ResponseModel UpdatePaymentMenthod(string id, RequestUserPaymentModel requestUserPaymentModel)
        {
            var userPaymentMethodEntity = _userPaymentMenthodRepository.GetSingle(x => id.Equals(x.Id));
            if (userPaymentMethodEntity == null)
            {
                return new ResponseModel
                {
                    MessageError = "Khong tim thay",
                    StatusCode = StatusCodes.Status404NotFound
                };
            }
            _mapper.Map(requestUserPaymentModel, userPaymentMethodEntity);
            _userPaymentMenthodRepository.Update(userPaymentMethodEntity);
            return new ResponseModel
            {
                StatusCode = StatusCodes.Status200OK
            };
        }
        //Delete bY ID
        public ResponseModel DeletePaymentMenthod(string id)
        {
            var userPaymentMethodEntity = _userPaymentMenthodRepository.GetSingle(x => x.Id.Equals(id));
            if (userPaymentMethodEntity == null)
            {
                return new ResponseModel
                {
                    MessageError = "Khong tim thay",
                    StatusCode = StatusCodes.Status404NotFound
                };
            }
            _userPaymentMenthodRepository.Delete(userPaymentMethodEntity);
            return new ResponseModel
            {
                StatusCode = StatusCodes.Status200OK
            };
        }
    }
}
