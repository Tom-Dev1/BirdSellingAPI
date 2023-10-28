﻿// <auto-generated />
using System;
using BirdSellingAPI._3._Repository.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BirdSellingAPI.Migrations
{
    [DbContext(typeof(BirdFarmContext))]
    partial class BirdFarmContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BirdSellingAPI._3._Repository.Data.BirdCategoryEntity", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTimeOffset>("CreatedTime")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTimeOffset?>("DeletedTime")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTimeOffset>("LastUpdatedTime")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("category_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("BirdCategory");
                });

            modelBuilder.Entity("BirdSellingAPI._3._Repository.Data.NestEntity", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTimeOffset>("CreatedTime")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTimeOffset?>("DeletedTime")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTimeOffset>("LastUpdatedTime")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Nest");
                });

            modelBuilder.Entity("BirdSellingAPI._3._Repository.Data.OrderDetailEntity", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTimeOffset>("CreatedTime")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTimeOffset?>("DeletedTime")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTimeOffset>("LastUpdatedTime")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("nest_id")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("nest_id");

                    b.ToTable("OrderDetail");
                });

            modelBuilder.Entity("BirdSellingAPI._3._Repository.Data.OrderEntity", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTimeOffset>("CreatedTime")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTimeOffset?>("DeletedTime")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTimeOffset>("LastUpdatedTime")
                        .HasColumnType("datetimeoffset");

                    b.Property<bool?>("orderStatus")
                        .HasColumnType("bit");

                    b.Property<string>("orderTotal")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset>("order_date")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("shippingMenthod_id")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("shippingMenthod_id");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("BirdSellingAPI._3._Repository.Data.PaymentTypeEntity", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTimeOffset>("CreatedTime")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTimeOffset?>("DeletedTime")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTimeOffset>("LastUpdatedTime")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("paymentType");
                });

            modelBuilder.Entity("BirdSellingAPI._3._Repository.Data.ProductEntity", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTimeOffset>("CreatedTime")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTimeOffset?>("DeletedTime")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTimeOffset>("LastUpdatedTime")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("bird_father_id")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("bird_mother_id")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("category_id")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTimeOffset>("day_of_birth")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("is_egg")
                        .HasColumnType("bit");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("price")
                        .HasColumnType("decimal(38,4)");

                    b.Property<bool?>("sex")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("category_id");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("BirdSellingAPI._3._Repository.Data.PromotionCategoryEntity", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTimeOffset>("CreatedTime")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTimeOffset?>("DeletedTime")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTimeOffset>("LastUpdatedTime")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("PromotionEntityId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("birdCategory")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("promotion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("promotion_id")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("PromotionEntityId");

                    b.ToTable("PromotionCategory");
                });

            modelBuilder.Entity("BirdSellingAPI._3._Repository.Data.PromotionEntity", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTimeOffset>("CreatedTime")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTimeOffset?>("DeletedTime")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTimeOffset>("LastUpdatedTime")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset>("end_day")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset>("start_day")
                        .HasColumnType("datetimeoffset");

                    b.HasKey("Id");

                    b.ToTable("Promotion");
                });

            modelBuilder.Entity("BirdSellingAPI._3._Repository.Data.RoleEntity", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTimeOffset>("CreatedTime")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTimeOffset?>("DeletedTime")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTimeOffset>("LastUpdatedTime")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("role_name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Role");
                });

            modelBuilder.Entity("BirdSellingAPI._3._Repository.Data.UserEntity", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("AddressLine")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset>("CreatedTime")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTimeOffset?>("DeletedTime")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTimeOffset>("LastUpdatedTime")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTimeOffset?>("createdAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("role_id")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("userEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("userName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("userPassword")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("userPhone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("role_id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("BirdSellingAPI._3._Repository.Data.UserPaymentMenthodEntity", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTimeOffset>("CreatedTime")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTimeOffset?>("DeletedTime")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTimeOffset>("LastUpdatedTime")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("account_number")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("paymentType_id")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("provide")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("paymentType_id");

                    b.ToTable("UserPaymentMenthod");
                });

            modelBuilder.Entity("BirdSellingAPI._3._Repository.Data.UserRefreshToken", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTimeOffset>("CreatedTime")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTimeOffset?>("DeletedTime")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTime>("ExpireTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("JwtId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset>("LastUpdatedTime")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("RefreshToken")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("User_Id")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("isUsed")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("User_Id");

                    b.ToTable("UserRefreshToken");
                });

            modelBuilder.Entity("BirdSellingAPI._3._Repository.Data.shippingMenthodEntity", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTimeOffset>("CreatedTime")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTimeOffset?>("DeletedTime")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTimeOffset>("LastUpdatedTime")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ShippingMenthod");
                });

            modelBuilder.Entity("BirdSellingAPI._3._Repository.Data.userReviewEntiry", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTimeOffset>("CreatedTime")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTimeOffset?>("DeletedTime")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTimeOffset>("LastUpdatedTime")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("comment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("rating_value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("UserReview");
                });

            modelBuilder.Entity("BirdSellingAPI._3._Repository.Data.OrderDetailEntity", b =>
                {
                    b.HasOne("BirdSellingAPI._3._Repository.Data.NestEntity", "nest")
                        .WithMany("orderDetail")
                        .HasForeignKey("nest_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("nest");
                });

            modelBuilder.Entity("BirdSellingAPI._3._Repository.Data.OrderEntity", b =>
                {
                    b.HasOne("BirdSellingAPI._3._Repository.Data.shippingMenthodEntity", "shippingMenthodEntity")
                        .WithMany("order")
                        .HasForeignKey("shippingMenthod_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("shippingMenthodEntity");
                });

            modelBuilder.Entity("BirdSellingAPI._3._Repository.Data.ProductEntity", b =>
                {
                    b.HasOne("BirdSellingAPI._3._Repository.Data.BirdCategoryEntity", "BirdCategory")
                        .WithMany("Products")
                        .HasForeignKey("category_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BirdCategory");
                });

            modelBuilder.Entity("BirdSellingAPI._3._Repository.Data.PromotionCategoryEntity", b =>
                {
                    b.HasOne("BirdSellingAPI._3._Repository.Data.PromotionEntity", null)
                        .WithMany("Promotion")
                        .HasForeignKey("PromotionEntityId");
                });

            modelBuilder.Entity("BirdSellingAPI._3._Repository.Data.UserEntity", b =>
                {
                    b.HasOne("BirdSellingAPI._3._Repository.Data.RoleEntity", "Role")
                        .WithMany("UserEntities")
                        .HasForeignKey("role_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("BirdSellingAPI._3._Repository.Data.UserPaymentMenthodEntity", b =>
                {
                    b.HasOne("BirdSellingAPI._3._Repository.Data.PaymentTypeEntity", "paymentType")
                        .WithMany("PaymentMenthod")
                        .HasForeignKey("paymentType_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("paymentType");
                });

            modelBuilder.Entity("BirdSellingAPI._3._Repository.Data.UserRefreshToken", b =>
                {
                    b.HasOne("BirdSellingAPI._3._Repository.Data.UserEntity", "UserEntity")
                        .WithMany()
                        .HasForeignKey("User_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UserEntity");
                });

            modelBuilder.Entity("BirdSellingAPI._3._Repository.Data.BirdCategoryEntity", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("BirdSellingAPI._3._Repository.Data.NestEntity", b =>
                {
                    b.Navigation("orderDetail");
                });

            modelBuilder.Entity("BirdSellingAPI._3._Repository.Data.PaymentTypeEntity", b =>
                {
                    b.Navigation("PaymentMenthod");
                });

            modelBuilder.Entity("BirdSellingAPI._3._Repository.Data.PromotionEntity", b =>
                {
                    b.Navigation("Promotion");
                });

            modelBuilder.Entity("BirdSellingAPI._3._Repository.Data.RoleEntity", b =>
                {
                    b.Navigation("UserEntities");
                });

            modelBuilder.Entity("BirdSellingAPI._3._Repository.Data.shippingMenthodEntity", b =>
                {
                    b.Navigation("order");
                });
#pragma warning restore 612, 618
        }
    }
}
