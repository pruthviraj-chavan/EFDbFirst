using System;
using System.Collections.Generic;

namespace EFDbFirst.Models;

public partial class Student
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Contact { get; set; } = null!;

    public string ProfileImage { get; set; } = null!;

    public int GenderId { get; set; }

    public virtual Address? Address { get; set; }

    public virtual Gender Gender { get; set; } = null!;
}
