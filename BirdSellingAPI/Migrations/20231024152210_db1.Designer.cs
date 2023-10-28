﻿// <auto-generated />
using System;
using BirdSellingAPI._3._Repository.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BirdSellingAPI.Migrations
{
    [DbContext(typeof(BirdFarmContext))]
    [Migration("20231024152210_db1")]
    partial class db1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BirdSellingAPI._3._Repository.Data.AddressEntity", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("AddressLine")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset>("CreatedTime")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTimeOffset?>("DeletedTime")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTimeOffset>("LastUpdatedTime")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Region")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Address");
                });

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

            modelBuilder.Entity("BirdSellingAPI._3._Repository.Data.OrderDetail", b =>
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
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("is_egg")
                        .HasColumnType("bit");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("price")
                        .HasColumnType("decimal(18,2)");

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

                    b.Property<string>("promotionCategory")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("promotionCategory_id")
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

                    b.Property<DateTimeOffset>("CreatedTime")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTimeOffset?>("DeletedTime")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTimeOffset>("LastUpdatedTime")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("address_id")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

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

                    b.HasIndex("address_id");

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

            modelBuilder.Entity("BirdSellingAPI._3._Repository.Data.paymentType", b =>
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

                    b.ToTable("paymentType");
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

            modelBuilder.Entity("BirdSellingAPI._3._Repository.Data.OrderDetail", b =>
                {
                    b.HasOne("BirdSellingAPI._3._Repository.Data.NestEntity", "nest")
                        .WithMany("orderDetail")
                        .HasForeignKey("nest_id");

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
                        .WithMany("PromotionCategory")
                        .HasForeignKey("PromotionEntityId");
                });

            modelBuilder.Entity("BirdSellingAPI._3._Repository.Data.UserEntity", b =>
                {
                    b.HasOne("BirdSellingAPI._3._Repository.Data.AddressEntity", "address")
                        .WithMany()
                        .HasForeignKey("address_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BirdSellingAPI._3._Repository.Data.RoleEntity", "Role")
                        .WithMany("UserEntities")
                        .HasForeignKey("role_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");

                    b.Navigation("address");
                });

            modelBuilder.Entity("BirdSellingAPI._3._Repository.Data.UserPaymentMenthodEntity", b =>
                {
                    b.HasOne("BirdSellingAPI._3._Repository.Data.paymentType", "paymentType")
                        .WithMany("PaymentMenthod")
                        .HasForeignKey("paymentType_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("paymentType");
                });

            modelBuilder.Entity("BirdSellingAPI._3._Repository.Data.BirdCategoryEntity", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("BirdSellingAPI._3._Repository.Data.NestEntity", b =>
                {
                    b.Navigation("orderDetail");
                });

            modelBuilder.Entity("BirdSellingAPI._3._Repository.Data.PromotionEntity", b =>
                {
                    b.Navigation("PromotionCategory");
                });

            modelBuilder.Entity("BirdSellingAPI._3._Repository.Data.RoleEntity", b =>
                {
                    b.Navigation("UserEntities");
                });

            modelBuilder.Entity("BirdSellingAPI._3._Repository.Data.paymentType", b =>
                {
                    b.Navigation("PaymentMenthod");
                });

            modelBuilder.Entity("BirdSellingAPI._3._Repository.Data.shippingMenthodEntity", b =>
                {
                    b.Navigation("order");
                });
#pragma warning restore 612, 618
        }
    }
}
