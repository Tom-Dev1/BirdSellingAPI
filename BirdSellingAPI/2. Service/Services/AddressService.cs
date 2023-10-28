using AutoMapper;
using BirdSellingAPI._2._Service.IServices;
using BirdSellingAPI._2._Service.Model;
using BirdSellingAPI._2._Service.Model.BirdCategory;
using BirdSellingAPI._3._Repository.BaseRepository;
using BirdSellingAPI._3._Repository.Data;
using BirdSellingAPI._4._Core.Model.Address;

namespace BirdSellingAPI._2._Service.Services
{
    public class AddressService : IAddressService

    {
        private readonly IRepositoryBase<AddressEntity> _addressRepository;
        private readonly IMapper _mapper;

        public AddressService(IRepositoryBase<AddressEntity> repositoryBase, IMapper mapper) 
        {
            _addressRepository = repositoryBase;
            _mapper = mapper;

        }
        public ResponseModel CreateAddress(RequestAddressModel entity)
        {
            var addressEntity = _mapper.Map<AddressEntity>(entity);
            _addressRepository.Create(addressEntity);
            return new ResponseModel
            {
                Data = addressEntity,
                MessageError = "",
                StatusCode = StatusCodes.Status200OK
            };
        }
        public ResponseModel GetAll()
        {
            var response = _addressRepository.GetAll();
            return new ResponseModel
            {
                Data = response,
                MessageError = "",
                StatusCode = StatusCodes.Status200OK
            };
        }

        public ResponseModel GetSingleID(string id)
        {
            var addressEntity = _addressRepository.GetSingle(x => x.Id.Equals(id));
            var responseAddressModel = _mapper.Map<AddressEntity>(addressEntity);
            return new ResponseModel
            {
                Data = addressEntity,
                MessageError = "",
                StatusCode = StatusCodes.Status200OK
            };
        }
        public ResponseModel UpdateAddress(string id, RequestAddressModel requestAddressModel)
        {
            var addressEntity = _addressRepository.GetSingle(x => id.Equals(x.Id));
            if (addressEntity == null)
            {
                return new ResponseModel
                {
                    MessageError = "Khong tim thay",
                    StatusCode = StatusCodes.Status404NotFound
                };
            }
            _mapper.Map(requestAddressModel, addressEntity);
            _addressRepository.Update(addressEntity);
            return new ResponseModel
            {
                StatusCode = StatusCodes.Status200OK
            };
        }
        public ResponseModel DeleteAddress(string id)
        {
            var birdCategoryEntity = _addressRepository.GetSingle(x => x.Id.Equals(id));
            if (birdCategoryEntity == null)
            {
                return new ResponseModel
                {
                    MessageError = "Khong tim thay",
                    StatusCode = StatusCodes.Status404NotFound
                };
            }
            _addressRepository.Delete(birdCategoryEntity);
            return new ResponseModel
            {
                StatusCode = StatusCodes.Status200OK
            };
        }
    }
}
