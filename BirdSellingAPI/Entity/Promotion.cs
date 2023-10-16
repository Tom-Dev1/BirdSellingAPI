using System;
using System.Collections.Generic;

namespace BirdSellingAPI.Entity;

public partial class Promotion
{
    public int PromotionId { get; set; }

    public int PromotionCategoryId { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }
}
