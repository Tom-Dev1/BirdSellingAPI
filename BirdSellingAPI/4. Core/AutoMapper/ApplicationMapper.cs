using AutoMapper;
using BirdSellingAPI._2._Service.Model.BirdCategory;
using BirdSellingAPI._3._Repository.Data;
using BirdSellingAPI._4._Core.Model.Nest;
using BirdSellingAPI._4._Core.Model.Order;
using BirdSellingAPI._4._Core.Model.OrderDetail;
using BirdSellingAPI._4._Core.Model.PaymentType;
using BirdSellingAPI._4._Core.Model.Product;
using BirdSellingAPI._4._Core.Model.Promotion;
using BirdSellingAPI._4._Core.Model.PromotionCategory;
using BirdSellingAPI._4._Core.Model.Role;
using BirdSellingAPI._4._Core.Model.ShippingMenthod;
using BirdSellingAPI._4._Core.Model.User;
using BirdSellingAPI._4._Core.Model.UserPaymentMenthod;
using BirdSellingAPI._4._Core.Model.UserReview;

namespace CarCategoriesApi.Helpers
{
    public class ApplicationMapper : Profile
    {
        public ApplicationMapper() 
        {
            //BirdCategory
            CreateMap<BirdCategoryEntity, RequestBirdCategoryModel>().ReverseMap();
            CreateMap<BirdCategoryEntity, ResponseBirdCategoryModel>().ReverseMap();

            //Product
            CreateMap<ProductEntity, RequestProductModel>().ReverseMap();
            CreateMap<ProductEntity, ResponseProductModel>().ReverseMap();


            //Nest
            CreateMap<NestEntity, RequestNestModel>().ReverseMap();
            CreateMap<NestEntity, ResponseNestModel>().ReverseMap();

            //Order
            CreateMap<OrderEntity, RequestOrderModel>().ReverseMap();
            CreateMap<OrderEntity, ResponseOrderModel>().ReverseMap();

            //OrderDetail
            CreateMap<OrderDetailEntity, RequestOrderDetailModel>().ReverseMap();
            CreateMap<OrderDetailEntity, ResponseOrderDetailModel>().ReverseMap();

            //PaymentType
            CreateMap<PaymentTypeEntity, RequestPaymentTypeModel>().ReverseMap();
            CreateMap<PaymentTypeEntity, ResponsePaymentTypeModel>().ReverseMap();

            //Promotion
            CreateMap<PromotionEntity, RequestPromotionModel>().ReverseMap();
            CreateMap<PromotionEntity, ResponsePromotionModel>().ReverseMap();

            //Promotion Category
            CreateMap<PromotionCategoryEntity, RequestPromotionCategoryModel>().ReverseMap();
            CreateMap<PromotionCategoryEntity, ResponsePromotionCategoryModel>().ReverseMap();

            //Role
            CreateMap<RoleEntity, RequestRoleModel>().ReverseMap();
            CreateMap<RoleEntity, ResponseRoleModel>().ReverseMap();

            //ShippingMenthod
            CreateMap<shippingMenthodEntity, RequestShippingMenthodModel>().ReverseMap();
            CreateMap<shippingMenthodEntity, ResponseShippingMenthodModel>().ReverseMap();

            //User
            CreateMap<UserEntity, RequestUserModel>().ReverseMap();
            CreateMap<UserEntity, ResponseUserModel>().ReverseMap();

            //User PaymentMenthod
            CreateMap<UserPaymentMenthodEntity, RequestUserPaymentModel>().ReverseMap();
            CreateMap<UserPaymentMenthodEntity, ResponseUserPaymentModel>().ReverseMap();

            //User Review
            CreateMap<userReviewEntiry, RequestUserReviewModel>().ReverseMap();
            CreateMap<userReviewEntiry, ResponseUserReviewModel>().ReverseMap();
        }
    }
}
