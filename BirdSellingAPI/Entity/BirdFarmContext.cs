using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace BirdSellingAPI.Entity;

public partial class BirdFarmContext : DbContext
{
    public BirdFarmContext()
    {
    }

    public BirdFarmContext(DbContextOptions<BirdFarmContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Address> Addresses { get; set; }

    public virtual DbSet<BirdCategory> BirdCategories { get; set; }

    public virtual DbSet<BirdId> BirdIds { get; set; }

    public virtual DbSet<OrderId> OrderIds { get; set; }

    public virtual DbSet<OrderStatus> OrderStatuses { get; set; }

    public virtual DbSet<PaymentType> PaymentTypes { get; set; }

    public virtual DbSet<Promotion> Promotions { get; set; }

    public virtual DbSet<PromotionCategory> PromotionCategories { get; set; }

    public virtual DbSet<RoleId> RoleIds { get; set; }

    public virtual DbSet<ShippingMenthodId> ShippingMenthodIds { get; set; }

    public virtual DbSet<ShopOrder> ShopOrders { get; set; }

    public virtual DbSet<ShoppingCartId> ShoppingCartIds { get; set; }

    public virtual DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<UserPaymentMenthod> UserPaymentMenthods { get; set; }

    public virtual DbSet<UserReview> UserReviews { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=BirdFarm;Integrated Security=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Address>(entity =>
        {
            entity.ToTable("address");

            entity.Property(e => e.AddressId)
                .ValueGeneratedNever()
                .HasColumnName("address_id");
            entity.Property(e => e.AddressLine1)
                .HasMaxLength(255)
                .HasColumnName("address_line1");
            entity.Property(e => e.City)
                .HasMaxLength(255)
                .HasColumnName("city");
            entity.Property(e => e.Country)
                .HasMaxLength(255)
                .HasColumnName("country");
            entity.Property(e => e.Region)
                .HasMaxLength(255)
                .HasColumnName("region");
        });

        modelBuilder.Entity<BirdCategory>(entity =>
        {
            entity.HasKey(e => e.CategoryId);

            entity.ToTable("birdCategory");

            entity.Property(e => e.CategoryId)
                .ValueGeneratedNever()
                .HasColumnName("category_id");
            entity.Property(e => e.CategoryName)
                .HasMaxLength(50)
                .HasColumnName("categoryName");
        });

        modelBuilder.Entity<BirdId>(entity =>
        {
            entity.HasKey(e => e.BirdId1);

            entity.ToTable("Bird_ID");

            entity.Property(e => e.BirdId1)
                .ValueGeneratedNever()
                .HasColumnName("bird_id");
            entity.Property(e => e.BirdFatherId).HasColumnName("birdFather_id");
            entity.Property(e => e.BirdMotherId).HasColumnName("birdMother_id");
            entity.Property(e => e.CategoryId).HasColumnName("category_id");
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .HasColumnName("description");
            entity.Property(e => e.Image)
                .HasColumnType("image")
                .HasColumnName("image");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
            entity.Property(e => e.Price)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("price");
            entity.Property(e => e.Sex)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("sex");
        });

        modelBuilder.Entity<OrderId>(entity =>
        {
            entity.HasKey(e => e.OrderId1);

            entity.ToTable("orderID");

            entity.Property(e => e.OrderId1)
                .ValueGeneratedNever()
                .HasColumnName("order_id");
            entity.Property(e => e.Bird).HasColumnName("bird");
            entity.Property(e => e.Price)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("price");
            entity.Property(e => e.Quantity).HasColumnName("quantity");
            entity.Property(e => e.ShopOderId).HasColumnName("shopOder_id");
        });

        modelBuilder.Entity<OrderStatus>(entity =>
        {
            entity.ToTable("orderStatus");

            entity.Property(e => e.OrderStatusId)
                .ValueGeneratedNever()
                .HasColumnName("orderStatus_id");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .HasColumnName("status");
        });

        modelBuilder.Entity<PaymentType>(entity =>
        {
            entity.ToTable("paymentType");

            entity.Property(e => e.PaymentTypeId)
                .ValueGeneratedNever()
                .HasColumnName("paymentType_id");
            entity.Property(e => e.Value).HasColumnName("value");
        });

        modelBuilder.Entity<Promotion>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("promotion");

            entity.Property(e => e.Description)
                .HasMaxLength(50)
                .HasColumnName("description");
            entity.Property(e => e.EndDate)
                .HasColumnType("date")
                .HasColumnName("end_date");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
            entity.Property(e => e.PromotionCategoryId).HasColumnName("promotionCategory_id");
            entity.Property(e => e.PromotionId).HasColumnName("promotion_id");
            entity.Property(e => e.StartDate)
                .HasColumnType("date")
                .HasColumnName("start_date");
        });

        modelBuilder.Entity<PromotionCategory>(entity =>
        {
            entity.ToTable("promotionCategory");

            entity.Property(e => e.PromotionCategoryId)
                .ValueGeneratedNever()
                .HasColumnName("promotionCategory_id");
            entity.Property(e => e.CategoryId).HasColumnName("category_id");
        });

        modelBuilder.Entity<RoleId>(entity =>
        {
            entity.HasKey(e => e.RoleId1).HasName("PK_roleID");

            entity.ToTable("role_ID");

            entity.Property(e => e.RoleId1)
                .ValueGeneratedNever()
                .HasColumnName("role_id");
            entity.Property(e => e.Description)
                .HasMaxLength(50)
                .HasColumnName("description");
            entity.Property(e => e.RoleName)
                .HasMaxLength(50)
                .HasColumnName("roleName");
        });

        modelBuilder.Entity<ShippingMenthodId>(entity =>
        {
            entity.HasKey(e => e.ShippingMenthodId1).HasName("PK_shippingMenthodID");

            entity.ToTable("shippingMenthod_ID");

            entity.Property(e => e.ShippingMenthodId1)
                .ValueGeneratedNever()
                .HasColumnName("shippingMenthod_id");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
        });

        modelBuilder.Entity<ShopOrder>(entity =>
        {
            entity.ToTable("shopOrders");

            entity.Property(e => e.ShopOrderId)
                .ValueGeneratedNever()
                .HasColumnName("shopOrder_id");
            entity.Property(e => e.OderDate)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("oderDate");
            entity.Property(e => e.OrderStatusId).HasColumnName("orderStatus_id");
            entity.Property(e => e.OrderTotal)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("orderTotal");
            entity.Property(e => e.PaymentMenthodId).HasColumnName("paymentMenthod_id");
            entity.Property(e => e.ShippingAddress)
                .HasMaxLength(255)
                .HasColumnName("shippingAddress");
            entity.Property(e => e.ShippingMenthodId)
                .HasMaxLength(255)
                .HasColumnName("shippingMenthod_id");
            entity.Property(e => e.UserId).HasColumnName("user_id");
        });

        modelBuilder.Entity<ShoppingCartId>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("shoppingCart_ID");

            entity.Property(e => e.ShoppingCartId1).HasColumnName("shoppingCart_id");
            entity.Property(e => e.UserId).HasColumnName("user_id");
        });

        modelBuilder.Entity<ShoppingCartItem>(entity =>
        {
            entity.ToTable("shoppingCart_Item");

            entity.Property(e => e.ShoppingCartItemId)
                .ValueGeneratedNever()
                .HasColumnName("shoppingCartItem_id");
            entity.Property(e => e.BirdId).HasColumnName("bird_id");
            entity.Property(e => e.ShoppingCartId).HasColumnName("shoppingCart_id");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.ToTable("user");

            entity.Property(e => e.UserId)
                .ValueGeneratedNever()
                .HasColumnName("user_id");
            entity.Property(e => e.AddressId).HasColumnName("address_id");
            entity.Property(e => e.CreateAt)
                .HasColumnType("datetime")
                .HasColumnName("createAt");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .HasColumnName("email");
            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .HasColumnName("password");
            entity.Property(e => e.Phone)
                .HasMaxLength(20)
                .HasColumnName("phone");
            entity.Property(e => e.RoleId).HasColumnName("role_id");
            entity.Property(e => e.StatusId).HasColumnName("status_id");
            entity.Property(e => e.Username)
                .HasMaxLength(50)
                .HasColumnName("username");
        });

        modelBuilder.Entity<UserPaymentMenthod>(entity =>
        {
            entity.ToTable("userPaymentMenthod");

            entity.Property(e => e.UserPaymentMenthodId)
                .ValueGeneratedNever()
                .HasColumnName("userPaymentMenthod_id");
            entity.Property(e => e.AccountNumber)
                .HasMaxLength(255)
                .HasColumnName("accountNumber");
            entity.Property(e => e.IdDefault).HasColumnName("id_default");
            entity.Property(e => e.PaymentTypeId).HasColumnName("paymentType_id");
            entity.Property(e => e.Provide)
                .HasMaxLength(255)
                .HasColumnName("provide");
            entity.Property(e => e.UserId).HasColumnName("user_id");
        });

        modelBuilder.Entity<UserReview>(entity =>
        {
            entity.ToTable("userReview");

            entity.Property(e => e.UserReviewId)
                .ValueGeneratedNever()
                .HasColumnName("userReview_id");
            entity.Property(e => e.BirdId).HasColumnName("bird_id");
            entity.Property(e => e.Comment)
                .HasMaxLength(255)
                .HasColumnName("comment");
            entity.Property(e => e.RatingValue).HasColumnName("ratingValue");
            entity.Property(e => e.UserId).HasColumnName("user_id");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
