using AutoMapper;
using BirdSellingAPI._2._Service.IServices;
using BirdSellingAPI._2._Service.Model;
using BirdSellingAPI._2._Service.Model.BirdCategory;
using BirdSellingAPI._3._Repository.BaseRepository;
using BirdSellingAPI._3._Repository.Data;
using BirdSellingAPI._4._Core.Model.Nest;

namespace BirdSellingAPI._2._Service.Services
{
    public class NestService : INestService
    {
        private readonly IRepositoryBase<NestEntity> _nestRepository;
        private readonly IMapper _mapper;

        public NestService(IRepositoryBase<NestEntity> repositoryBase, IMapper mapper) 
        {
            _nestRepository = repositoryBase;
            _mapper = mapper;
        }

        public ResponseModel CreateNest(RequestNestModel entity)    
        {
            var nestEntity = _mapper.Map<NestEntity>(entity);   
            _nestRepository.Create(nestEntity);
            return new ResponseModel
            {
                Data = nestEntity,
                MessageError = "",
                StatusCode = StatusCodes.Status200OK
            };
        }
        public ResponseModel GetAll()
        {
            var response = _nestRepository.GetAll();
            return new ResponseModel
            {
                Data = response,
                MessageError = "",
                StatusCode = StatusCodes.Status200OK
            };
        }
        public ResponseModel GetSingle(string id)
        {
            var nestEntity = _nestRepository.GetSingle(x => x.Id.Equals(id));
            var responseNestModel = _mapper.Map<ResponseNestModel>(nestEntity);
            return new ResponseModel
            {
                Data = nestEntity,
                MessageError = "",
                StatusCode = StatusCodes.Status200OK
            };
        }

        //Update
        public ResponseModel UpdateNest(string id, RequestNestModel requestNestModel)

        {
            var nestEntity = _nestRepository.GetSingle(x => id.Equals(x.Id));
            if (nestEntity == null)
            {
                return new ResponseModel
                {
                    MessageError = "Khong tim thay",
                    StatusCode = StatusCodes.Status404NotFound
                };
            }
            _mapper.Map(requestNestModel, nestEntity);
            _nestRepository.Update(nestEntity);
            return new ResponseModel
            {
                StatusCode = StatusCodes.Status200OK
            };
        }
        // Delete
        public ResponseModel DeleteNest(string id)
        {
            var nestEntity = _nestRepository.GetSingle(x => x.Id.Equals(id));
            if (nestEntity == null)
            {
                return new ResponseModel
                {
                    MessageError = "Khong tim thay",
                    StatusCode = StatusCodes.Status404NotFound
                };
            }
            _nestRepository.Delete(nestEntity);
            return new ResponseModel
            {
                StatusCode = StatusCodes.Status200OK
            };
        }
    }
}
