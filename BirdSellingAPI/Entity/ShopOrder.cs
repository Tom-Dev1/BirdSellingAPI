using System;
using System.Collections.Generic;

namespace BirdSellingAPI.Entity;

public partial class ShopOrder
{
    public int ShopOrderId { get; set; }

    public int UserId { get; set; }

    public byte[] OderDate { get; set; } = null!;

    public int PaymentMenthodId { get; set; }

    public string ShippingAddress { get; set; } = null!;

    public string ShippingMenthodId { get; set; } = null!;

    public decimal OrderTotal { get; set; }

    public int OrderStatusId { get; set; }
}
