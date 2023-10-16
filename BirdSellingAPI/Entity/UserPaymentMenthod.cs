using System;
using System.Collections.Generic;

namespace BirdSellingAPI.Entity;

public partial class UserPaymentMenthod
{
    public int UserPaymentMenthodId { get; set; }

    public int UserId { get; set; }

    public int PaymentTypeId { get; set; }

    public string Provide { get; set; } = null!;

    public string AccountNumber { get; set; } = null!;

    public bool IdDefault { get; set; }
}
