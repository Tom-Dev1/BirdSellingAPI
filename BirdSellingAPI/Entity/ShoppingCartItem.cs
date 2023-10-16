using System;
using System.Collections.Generic;

namespace BirdSellingAPI.Entity;

public partial class ShoppingCartItem
{
    public int ShoppingCartItemId { get; set; }

    public int ShoppingCartId { get; set; }

    public int BirdId { get; set; }
}
