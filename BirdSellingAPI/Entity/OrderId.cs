using System;
using System.Collections.Generic;

namespace BirdSellingAPI.Entity;

public partial class OrderId
{
    public int OrderId1 { get; set; }

    public int Bird { get; set; }

    public int ShopOderId { get; set; }

    public int Quantity { get; set; }

    public decimal Price { get; set; }
}
