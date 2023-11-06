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
        public DbSet<ProductEntity> productEntities { get; set; }
        public DbSet<CartEntity> cartEntities { get; set; }
        public DbSet<OrderEntity> orderEntities { get; set; }
        public DbSet<RoleEntity> roleEntities { get; set; }
        public DbSet<UserEntity> userEntities { get; set; }
        public DbSet<PhoiGiongEntity> phoiGiongEntities { get; set; }
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
