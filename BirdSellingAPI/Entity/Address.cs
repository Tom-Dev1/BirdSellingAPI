using System;
using System.Collections.Generic;

namespace BirdSellingAPI.Entity;

public partial class Address
{
    public int AddressId { get; set; }

    public string AddressLine1 { get; set; } = null!;

    public string City { get; set; } = null!;

    public string Region { get; set; } = null!;

    public string Country { get; set; } = null!;
}
