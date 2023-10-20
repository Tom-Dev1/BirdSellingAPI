using AutoMapper;
using BirdSellingAPI._2._Service.Model.BirdCategory;
using BirdSellingAPI._3._Repository.Data;
using BirdSellingAPI._4._Core.Model.Product;

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

        }
    }
}
