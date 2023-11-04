using AutoMapper;
using BirdSellingAPI._2._Service.IServices;
using BirdSellingAPI._2._Service.Model.BirdCategory;
using BirdSellingAPI._2._Service.Model;
using BirdSellingAPI._3._Repository.BaseRepository;
using BirdSellingAPI._3._Repository.Data;
using BirdSellingAPI._4._Core.Model.UserReview;

namespace BirdSellingAPI._2._Service.Services
{
    public class UserReviewModelService : IUserReviewModelService
    {
        private readonly IRepositoryBase<userReviewEntiry> _userReviewRepository;
        private readonly IMapper _mapper;

        public UserReviewModelService(IRepositoryBase<userReviewEntiry> repositoryBase, IMapper mapper) 
        {
            _userReviewRepository = repositoryBase;  
            _mapper = mapper;
        }
        public ResponseModel CreateUserReview(RequestUserReviewModel entity)
        {
            var userReviewEntity = _mapper.Map<userReviewEntiry>(entity);
            _userReviewRepository.Create(userReviewEntity);
            return new ResponseModel
            {
                Data = userReviewEntity,
                MessageError = "",
                StatusCode = StatusCodes.Status200OK
            };
        }
        //Get ALL
        public ResponseModel GetAll()
        {
            var entities = _userReviewRepository.GetAll().ToList();
            var response = _mapper.Map<List<ResponseUserReviewModel>>(entities.ToList());
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
            var userReviewEntity = _userReviewRepository.GetSingle(x => x.Id.Equals(id));
            var responseBirdCategoryModel = _mapper.Map<ResponseUserReviewModel>(userReviewEntity);
            return new ResponseModel
            {
                Data = userReviewEntity,
                MessageError = "",
                StatusCode = StatusCodes.Status200OK
            };
        }
        //Update
        public ResponseModel UpdateReview(string id, RequestUserReviewModel requestUserReviewModel)
        {
            var userReviewEntity = _userReviewRepository.GetSingle(x => id.Equals(x.Id));
            if (userReviewEntity == null)
            {
                return new ResponseModel
                {
                    MessageError = "Khong tim thay",
                    StatusCode = StatusCodes.Status404NotFound
                };
            }
            _mapper.Map(requestUserReviewModel, userReviewEntity);
            _userReviewRepository.Update(userReviewEntity);
            return new ResponseModel
            {
                StatusCode = StatusCodes.Status200OK
            };
        }

        //Delete bY ID
        public ResponseModel DeleteUseReview(string id)
        {
            var userReviewEntity = _userReviewRepository.GetSingle(x => x.Id.Equals(id));
            if (userReviewEntity == null)
            {
                return new ResponseModel
                {
                    MessageError = "Khong tim thay",
                    StatusCode = StatusCodes.Status404NotFound
                };
            }
            _userReviewRepository.Delete(userReviewEntity);
            return new ResponseModel
            {
                StatusCode = StatusCodes.Status200OK
            };
        }
    }
}
