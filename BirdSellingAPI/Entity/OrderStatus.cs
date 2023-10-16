using System;
using System.Collections.Generic;

namespace BirdSellingAPI.Entity;

public partial class OrderStatus
{
    public int OrderStatusId { get; set; }

    public string Status { get; set; } = null!;
}
