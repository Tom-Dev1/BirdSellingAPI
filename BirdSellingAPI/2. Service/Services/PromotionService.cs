using AutoMapper;
using BirdSellingAPI._2._Service.IServices;
using BirdSellingAPI._2._Service.Model.BirdCategory;
using BirdSellingAPI._2._Service.Model;
using BirdSellingAPI._3._Repository.BaseRepository;
using BirdSellingAPI._3._Repository.Data;
using BirdSellingAPI._4._Core.Model.Promotion;

namespace BirdSellingAPI._2._Service.Services
{
    public class PromotionService : IPromotionService
    {
        private readonly IRepositoryBase<PromotionEntity> _promotionRepository;
        private readonly IMapper _mapper;

        public PromotionService(IRepositoryBase<PromotionEntity> repositoryBase, IMapper mapper) 
        {
            _promotionRepository = repositoryBase;
            _mapper = mapper;
        }
        //Get ALL
        public ResponseModel GetAll()
        {
            var response = _promotionRepository.GetAll();
            return new ResponseModel
            {
                Data = response,
                MessageError = "",
                StatusCode = StatusCodes.Status200OK
            };
        }

    }
}
