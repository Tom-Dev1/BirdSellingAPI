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

//Service
builder.Services.AddScoped<IBirdCategoryService, BirdCategoryService>();
builder.Services.AddScoped<IProductService, ProductService>();

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
