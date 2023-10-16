using System;
using System.Collections.Generic;

namespace BirdSellingAPI.Entity;

public partial class BirdId
{
    public int BirdId1 { get; set; }

    public byte[] Image { get; set; } = null!;

    public decimal Price { get; set; }

    public string Name { get; set; } = null!;

    public int CategoryId { get; set; }

    public string Sex { get; set; } = null!;

    public string Description { get; set; } = null!;

    public int BirdMotherId { get; set; }

    public int BirdFatherId { get; set; }
}
