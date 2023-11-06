using AutoMapper;
using BirdSellingAPI._2._Service.Model.BirdCategory;
using BirdSellingAPI._3._Repository.Data;
using BirdSellingAPI._4._Core.Model.Auth;
using BirdSellingAPI._4._Core.Model.Order;
using BirdSellingAPI._4._Core.Model.OrderDetail;
using BirdSellingAPI._4._Core.Model.Product;
using BirdSellingAPI._4._Core.Model.Role;
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


            //Order
            CreateMap<OrderEntity, RequestOrderModel>().ReverseMap();
            CreateMap<OrderEntity, ResponseOrderModel>().ReverseMap();

            //OrderDetail
            CreateMap<CartEntity, RequestCartModel>().ReverseMap();
            CreateMap<CartEntity, ResponseCartModel>().ReverseMap();


            //Role
            CreateMap<RoleEntity, RequestRoleModel>().ReverseMap();
            CreateMap<RoleEntity, ResponseRoleModel>().ReverseMap();


            //User
            CreateMap<UserEntity, RequestUserModel>().ReverseMap();
            CreateMap<UserEntity, ResponseUserModel>().ReverseMap();

            //User PaymentMenthod
            CreateMap<UserPaymentMenthodEntity, RequestUserPaymentModel>().ReverseMap();
            CreateMap<UserPaymentMenthodEntity, ResponseUserPaymentModel>().ReverseMap();

            //User Review
            CreateMap<userReviewEntiry, RequestUserReviewModel>().ReverseMap();
            CreateMap<userReviewEntiry, ResponseUserReviewModel>().ReverseMap();

            //User Auth
            CreateMap<UserEntity, SignUpModel>().ReverseMap();
            CreateMap<UserEntity, SignInModel>().ReverseMap();

        }
    }
}
