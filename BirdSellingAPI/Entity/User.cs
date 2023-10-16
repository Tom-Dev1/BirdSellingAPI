using System;
using System.Collections.Generic;

namespace BirdSellingAPI.Entity;

public partial class User
{
    public int UserId { get; set; }

    public string Username { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Phone { get; set; } = null!;

    public int AddressId { get; set; }

    public int RoleId { get; set; }

    public DateTime CreateAt { get; set; }

    public int StatusId { get; set; }
}
