using BirdSellingAPI._2._Service.IServices;
using BirdSellingAPI._2._Service.Services;
using BirdSellingAPI._3._Repository.BaseRepository;
using BirdSellingAPI._3._Repository.Data;
using BirdSellingAPI._3._Repository.Repository;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<BirdFarmContext> (options => 
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("BirdFarm"));
});
builder.Services.AddAutoMapper(typeof(Program));

// Repository
builder.Services.AddScoped<IRepositoryBase<BirdCategoryEntity>, RepositoryBase<BirdCategoryEntity>>();
builder.Services.AddScoped<IRepositoryBase<ProductEntity>, RepositoryBase<ProductEntity>>();
builder.Services.AddScoped<IRepositoryBase<NestEntity>, RepositoryBase<NestEntity>>();
builder.Services.AddScoped<IRepositoryBase<PaymentTypeEntity>, RepositoryBase<PaymentTypeEntity>>();
builder.Services.AddScoped<IRepositoryBase<PromotionEntity>, RepositoryBase<PromotionEntity>>();
builder.Services.AddScoped<IRepositoryBase<PromotionCategoryEntity>, RepositoryBase<PromotionCategoryEntity>>();
builder.Services.AddScoped<IRepositoryBase<RoleEntity>, RepositoryBase<RoleEntity>>();
builder.Services.AddScoped<IRepositoryBase<UserEntity>, RepositoryBase<UserEntity>>();
builder.Services.AddScoped<IRepositoryBase<UserPaymentMenthodEntity>, RepositoryBase<UserPaymentMenthodEntity>>();




//Service
builder.Services.AddScoped<IBirdCategoryService, BirdCategoryService>();
builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<INestService, NestService>();
builder.Services.AddScoped<IPaymentTypeService, PaymentTypeService>();
builder.Services.AddScoped<IPromotionService, PromotionService>();
builder.Services.AddScoped<IPromotionCategoryService, PromotionCategoryService>();
builder.Services.AddScoped<IRoleService, RoleService>();
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IUserPaymentMethodService, UserPaymentMethodService>();



var app = builder.Build();

// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
    app.UseSwagger();
    app.UseSwaggerUI();
   
//}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
