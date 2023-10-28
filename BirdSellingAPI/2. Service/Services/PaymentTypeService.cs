using AutoMapper;
using BirdSellingAPI._2._Service.IServices;
using BirdSellingAPI._2._Service.Model.BirdCategory;
using BirdSellingAPI._2._Service.Model;
using BirdSellingAPI._3._Repository.BaseRepository;
using BirdSellingAPI._3._Repository.Data;
using BirdSellingAPI._4._Core.Model.PaymentType;

namespace BirdSellingAPI._2._Service.Services
{
    public class PaymentTypeService : IPaymentTypeService
    {
        private readonly IRepositoryBase<PaymentTypeEntity> _paymentTypeRepository;
        private readonly IMapper _mapper;

        public PaymentTypeService(IRepositoryBase<PaymentTypeEntity> repositoryBase, IMapper mapper) 
        {
            _paymentTypeRepository = repositoryBase;
            _mapper = mapper;
        }
        public ResponseModel CreatePaymentType(RequestPaymentTypeModel entity)
        {
            var paymentTypeEntity = _mapper.Map<PaymentTypeEntity>(entity);
            _paymentTypeRepository.Create(paymentTypeEntity);
            return new ResponseModel
            {
                Data = paymentTypeEntity,
                MessageError = "",
                StatusCode = StatusCodes.Status200OK
            };
        }
        //GetID
        public ResponseModel GetSingleID(string id)
        {
            var paymentTypeEntity = _paymentTypeRepository.GetSingle(x => x.Id.Equals(id));
            var responseBirdCategoryModel = _mapper.Map<ResponsePaymentTypeModel>(paymentTypeEntity);
            return new ResponseModel
            {
                Data = paymentTypeEntity,
                MessageError = "",
                StatusCode = StatusCodes.Status200OK
            };
        }
        //Update
        public ResponseModel UpdatePaymentType(string id, RequestPaymentTypeModel requestPaymentTypeModel)
        {
            var paymentTypeEntity = _paymentTypeRepository.GetSingle(x => id.Equals(x.Id));
            if (paymentTypeEntity == null)
            {
                return new ResponseModel
                {
                    MessageError = "Khong tim thay",
                    StatusCode = StatusCodes.Status404NotFound
                };
            }
            _mapper.Map(requestPaymentTypeModel, paymentTypeEntity);
            _paymentTypeRepository.Update(paymentTypeEntity);
            return new ResponseModel
            {
                StatusCode = StatusCodes.Status200OK
            };
        }
        //Delete bY ID
        public ResponseModel DeletePaymentType(string id)
        {
            var paymentTypeEntity = _paymentTypeRepository.GetSingle(x => x.Id.Equals(id));
            if (paymentTypeEntity == null)
            {
                return new ResponseModel
                {
                    MessageError = "Khong tim thay",
                    StatusCode = StatusCodes.Status404NotFound
                };
            }
            _paymentTypeRepository.Delete(paymentTypeEntity);
            return new ResponseModel
            {
                StatusCode = StatusCodes.Status200OK
            };
        }

    }
}
