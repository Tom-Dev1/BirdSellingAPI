﻿using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BirdSellingAPI._3._Repository.Data
{
    [Table("Cart")]
    public class CartEntity : Entity
    {
       //foreign key for product
        public string product_id { get; set; }
        [ForeignKey(nameof(product_id))]
        public ProductEntity Product { get; set; }

        public string? order_id { get; set; }
        [Column(TypeName = "decimal(38,4)")]
        public decimal? price { get; set; }
        [Column(TypeName = "decimal(38,4)")]
        public decimal? quantity { get; set; }

        public string user_id { get; set; }
        [ForeignKey(nameof(user_id))]
        public UserEntity User { get; set; }
    }
}
