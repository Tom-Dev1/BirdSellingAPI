using BirdSellingAPI._2._Service.IServices;
using BirdSellingAPI._2._Service.Services;
using BirdSellingAPI._3._Repository.BaseRepository;
using BirdSellingAPI._3._Repository.Data;
using BirdSellingAPI._3._Repository.Repository;
using BirdSellingAPI._4._Core.Helper;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Text;

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
builder.Services.AddAuthentication("Bearer").AddJwtBearer(options =>
{
    options.SaveToken = true;
    options.RequireHttpsMetadata = false;
    options.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuer = true,
        ValidateAudience = true,
        ValidAudience = builder.Configuration["JWT:ValidAudience"],
        ValidIssuer = builder.Configuration["JWT:ValidIssuer"],
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes
        (builder.Configuration["JWT:Secret"])),
        ClockSkew = TimeSpan.Zero
    };
});

// Repository
builder.Services.AddScoped<IRepositoryBase<BirdCategoryEntity>, RepositoryBase<BirdCategoryEntity>>();
builder.Services.AddScoped<IRepositoryBase<ProductEntity>, RepositoryBase<ProductEntity>>();
builder.Services.AddScoped<IRepositoryBase<NestEntity>, RepositoryBase<NestEntity>>();
builder.Services.AddScoped<IRepositoryBase<PaymentTypeEntity>, RepositoryBase<PaymentTypeEntity>>();
builder.Services.AddScoped<IRepositoryBase<PromotionEntity>, RepositoryBase<PromotionEntity>>();
builder.Services.AddScoped<IRepositoryBase<PromotionCategoryEntity>, RepositoryBase<PromotionCategoryEntity>>();
builder.Services.AddScoped<IRepositoryBase<RoleEntity>, RepositoryBase<RoleEntity>>();
builder.Services.AddScoped<IRepositoryBase<UserEntity>, RepositoryBase<UserEntity>>();
builder.Services.AddScoped<IRepositoryBase<UserRefreshToken>, RepositoryBase<UserRefreshToken>>();






//Service
builder.Services.AddScoped<IBirdCategoryService, BirdCategoryService>();
builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<INestService, NestService>();
builder.Services.AddScoped<IPaymentTypeService, PaymentTypeService>();
builder.Services.AddScoped<IPromotionService, PromotionService>();
builder.Services.AddScoped<IPromotionCategoryService, PromotionCategoryService>();
builder.Services.AddScoped<IRoleService, RoleService>();
builder.Services.AddScoped<IAuthService, AuthService>();


//Auth
builder.Services.AddScoped<GenerateToken>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
