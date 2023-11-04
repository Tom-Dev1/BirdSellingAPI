using BirdSellingAPI._2._Service.IServices;
using BirdSellingAPI._2._Service.Services;
using BirdSellingAPI._3._Repository.BaseRepository;
using BirdSellingAPI._3._Repository.Data;
using BirdSellingAPI._3._Repository.Repository;
using BirdSellingAPI._4._Core.Helper;
using BirdSellingAPI._4._Core.Model.EmailSettingModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCors(opts =>
{
    opts.AddPolicy("corspolicy", build =>
    {
        build.WithOrigins("*").AllowAnyMethod().AllowAnyHeader();
    });
});
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
EmailSettingModel.Instance = builder.Configuration.GetSection("EmailSettings").Get<EmailSettingModel>();
// Repository
builder.Services.AddScoped<IRepositoryBase<BirdCategoryEntity>, RepositoryBase<BirdCategoryEntity>>();
builder.Services.AddScoped<IRepositoryBase<ProductEntity>, RepositoryBase<ProductEntity>>();
builder.Services.AddScoped<IRepositoryBase<PaymentTypeEntity>, RepositoryBase<PaymentTypeEntity>>();
builder.Services.AddScoped<IRepositoryBase<RoleEntity>, RepositoryBase<RoleEntity>>();
builder.Services.AddScoped<IRepositoryBase<UserEntity>, RepositoryBase<UserEntity>>();
builder.Services.AddScoped<IRepositoryBase<CartEntity>, RepositoryBase<CartEntity>>();

builder.Services.AddScoped<IRepositoryBase<UserRefreshToken>, RepositoryBase<UserRefreshToken>>();

builder.Services.AddScoped<IRepositoryBase<UserPaymentMenthodEntity>, RepositoryBase<UserPaymentMenthodEntity>>();
builder.Services.AddScoped<IRepositoryBase<userReviewEntiry>, RepositoryBase<userReviewEntiry>>();





//Service
builder.Services.AddScoped<IBirdCategoryService, BirdCategoryService>();
builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<IPaymentTypeService, PaymentTypeService>();
builder.Services.AddScoped<IRoleService, RoleService>();
builder.Services.AddScoped<IAuthService, AuthService>();
builder.Services.AddScoped<IEmailService, EmailService>();
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IUserPaymentMethodService, UserPaymentMethodService>();
builder.Services.AddScoped<ICartService, CartService>();
builder.Services.AddScoped<IUserReviewModelService, UserReviewModelService>();




//Auth
builder.Services.AddScoped<GenerateToken>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
}
app.UseSwagger();
app.UseSwaggerUI();
app.UseCors("corspolicy");
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
