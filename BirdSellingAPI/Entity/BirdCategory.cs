using System;
using System.Collections.Generic;

namespace BirdSellingAPI.Entity;

public partial class BirdCategory
{
    public int CategoryId { get; set; }

    public string CategoryName { get; set; } = null!;
}
