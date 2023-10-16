using System;
using System.Collections.Generic;

namespace BirdSellingAPI.Entity;

public partial class UserReview
{
    public int UserReviewId { get; set; }

    public int UserId { get; set; }

    public int BirdId { get; set; }

    public int RatingValue { get; set; }

    public string Comment { get; set; } = null!;
}
