﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BirdSellingAPI._3._Repository.Data
{
    [Table("Address")]
    public class AddressEntity : Entity
    {

        public string? AddressLine { get; set; }

        public string? City { get; set; }

        public string? Region { get; set; }

        public string? Country { get; set; }

    }
}
