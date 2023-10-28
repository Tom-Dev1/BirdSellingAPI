using Microsoft.EntityFrameworkCore;
using System.Dynamic;

namespace BirdSellingAPI._3._Repository.Data
{
    public class BirdFarmContext : DbContext
    {
        IConfiguration _configuration;
        public BirdFarmContext()
        {

        }

        public BirdFarmContext(DbContextOptions<BirdFarmContext> opt) : base(opt)
        {
        }



        public DbSet<BirdCategoryEntity> birdCategoryEntities { get; set; }
        public DbSet<ProductEntity> birdEntities { get; set; }
        public DbSet<NestEntity> nestEntities { get; set; }
        public DbSet<OrderDetailEntity> orderDetails { get; set; }
        public DbSet<OrderEntity> orderEntities { get; set; }
        public DbSet<PaymentTypeEntity> paymentTypes { get; set; }
        public DbSet<PromotionCategoryEntity> promotionCategoryEntities { get; set; }
        public DbSet<PromotionEntity> promotionEntities { get; set; }
        public DbSet<RoleEntity> roleEntities { get; set; }
        public DbSet<shippingMenthodEntity> shippingMenthodEntities { get; set; }
        public DbSet<UserEntity> userEntities { get; set; }
        public DbSet<UserPaymentMenthodEntity> userPaymentMenthodEntities { get; set; }
        public DbSet<userReviewEntiry> userReviewEntiries { get; set; }
        public DbSet<UserRefreshToken> userRefreshTokens { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

                optionsBuilder.UseSqlServer(GetConnectionString());
            }
        }

        private string GetConnectionString()
        {
            IConfiguration config = new ConfigurationBuilder()
                 .SetBasePath(Directory.GetCurrentDirectory())
                        .AddJsonFile("appsettings.json", true, true)
                        .Build();
            var strConn = config["ConnectionStrings:BirdFarm"];

            return strConn;
        }

    }
}
