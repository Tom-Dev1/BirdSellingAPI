using AutoMapper;
using BirdSellingAPI._2._Service.IServices;
using BirdSellingAPI._2._Service.Model.BirdCategory;
using BirdSellingAPI._2._Service.Model;
using BirdSellingAPI._3._Repository.BaseRepository;
using BirdSellingAPI._3._Repository.Data;
using BirdSellingAPI._4._Core.Model.PromotionCategory;

namespace BirdSellingAPI._2._Service.Services
{
    public class PromotionCategoryService : IPromotionCategoryService
    {
        private readonly IRepositoryBase<PromotionCategoryEntity> _promotionCategoryRepository;
        private readonly IMapper _mapper;

        public PromotionCategoryService(IRepositoryBase<PromotionCategoryEntity> repositoryBase, IMapper mapper) 
        {
            _promotionCategoryRepository = repositoryBase;
            _mapper = mapper;
        }

        //Create
        public ResponseModel CreatePromotionCategory(RequestPromotionCategoryModel entity)
        {
            var promotionCategoryEntity = _mapper.Map<PromotionCategoryEntity>(entity);
            _promotionCategoryRepository.Create(promotionCategoryEntity);
            return new ResponseModel
            {
                Data = promotionCategoryEntity,
                MessageError = "",
                StatusCode = StatusCodes.Status200OK
            };
        }
        //Get ALL
        public ResponseModel GetAll()
        {
            var response = _promotionCategoryRepository.GetAll();
            return new ResponseModel
            {
                Data = response,
                MessageError = "",
                StatusCode = StatusCodes.Status200OK
            };
        }
        //GetID
        public ResponseModel GetSingleID(string id)
        {
            var promotionCategoryEntity = _promotionCategoryRepository.GetSingle(x => x.Id.Equals(id));
            var responseBirdCategoryModel = _mapper.Map<ResponsePromotionCategoryModel>(promotionCategoryEntity);
            return new ResponseModel
            {
                Data = promotionCategoryEntity,
                MessageError = "",
                StatusCode = StatusCodes.Status200OK
            };
        }
        //Update
        public ResponseModel UpdatePromotionCategory(string id, RequestPromotionCategoryModel requestPromotionCategoryModel)
        {
            var promotionCategoryEntity = _promotionCategoryRepository.GetSingle(x => id.Equals(x.Id));
            if (promotionCategoryEntity == null)
            {
                return new ResponseModel
                {
                    MessageError = "Khong tim thay",
                    StatusCode = StatusCodes.Status404NotFound
                };
            }
            _mapper.Map(requestPromotionCategoryModel, promotionCategoryEntity);
            _promotionCategoryRepository.Update(promotionCategoryEntity);
            return new ResponseModel
            {
                StatusCode = StatusCodes.Status200OK
            };
        }
        //Delete bY ID
        public ResponseModel DeletePromotionCategory(string id)
        {
            var promotionCategoryEntity = _promotionCategoryRepository.GetSingle(x => x.Id.Equals(id));
            if (promotionCategoryEntity == null)
            {
                return new ResponseModel
                {
                    MessageError = "Khong tim thay",
                    StatusCode = StatusCodes.Status404NotFound
                };
            }
            _promotionCategoryRepository.Delete(promotionCategoryEntity);
            return new ResponseModel
            {
                StatusCode = StatusCodes.Status200OK
            };
        }

    }
}
