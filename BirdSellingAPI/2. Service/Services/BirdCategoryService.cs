using AutoMapper;
using BirdSellingAPI._2._Service.IServices;
using BirdSellingAPI._2._Service.Model;
using BirdSellingAPI._2._Service.Model.BirdCategory;
using BirdSellingAPI._3._Repository.BaseRepository;
using BirdSellingAPI._3._Repository.Data;

namespace BirdSellingAPI._2._Service.Services
{
    public class BirdCategoryService : IBirdCategoryService
    {
        private readonly IRepositoryBase<BirdCategoryEntity> _birdCategoryRepository;
        private readonly IMapper _mapper;

        public BirdCategoryService(IRepositoryBase<BirdCategoryEntity> repositoryBase, IMapper mapper) 
        {
            _birdCategoryRepository = repositoryBase;
            _mapper = mapper;

        }


        public ResponseModel CreateBirdCategory(RequestBirdCategoryModel entity)
        {
            var birdCategoryEntity = _mapper.Map<BirdCategoryEntity>(entity);
            _birdCategoryRepository.Create(birdCategoryEntity);
            return new ResponseModel
            {
                Data = birdCategoryEntity,
                MessageError = "",
                StatusCode = StatusCodes.Status200OK
            };
        }
        //Get ALL
        public ResponseModel GetAll()
        {
            var entities = _birdCategoryRepository.GetAll().ToList();
            var response = _mapper.Map<List<ResponseBirdCategoryModel>>(entities.ToList());
            return new ResponseModel
            {
                Data = response,
                MessageError = "",
                StatusCode = StatusCodes.Status200OK
            };
        }

        public ResponseModel GetBirdCategoryByName(string? name) 
        {
            var response = _birdCategoryRepository.Get(x => x.category_name == name);
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
            var birdCategoryEntity = _birdCategoryRepository.GetSingle(x => x.Id.Equals(id));
            var responseBirdCategoryModel = _mapper.Map<ResponseBirdCategoryModel>(birdCategoryEntity);
            return new ResponseModel
            {
                Data = birdCategoryEntity,
                MessageError = "",
                StatusCode = StatusCodes.Status200OK
            };
        }

        //Update
        public ResponseModel UpdateBirdCategory(string id, RequestBirdCategoryModel requestBirdCategoryModel)       
        { 
            var birdCategoryEntity = _birdCategoryRepository.GetSingle(x => id.Equals(x.Id));
            if (birdCategoryEntity == null)
            {
                return new ResponseModel
                {
                    MessageError = "Khong tim thay",
                    StatusCode = StatusCodes.Status404NotFound
                };
            }
            _mapper.Map(requestBirdCategoryModel, birdCategoryEntity);
            _birdCategoryRepository.Update(birdCategoryEntity);
            return new ResponseModel
            {
                StatusCode = StatusCodes.Status200OK
            };
        }

        //Delete bY ID
        public ResponseModel DeleteBirdCategory(string id)
        {
            var birdCategoryEntity = _birdCategoryRepository.GetSingle(x => x.Id.Equals(id));
            if (birdCategoryEntity == null)
            {
                return new ResponseModel
                {
                    MessageError = "Khong tim thay",
                    StatusCode = StatusCodes.Status404NotFound
                };
            }
            _birdCategoryRepository.Delete(birdCategoryEntity);
            return new ResponseModel
            {
                StatusCode = StatusCodes.Status200OK
            };
        }

    }
}
