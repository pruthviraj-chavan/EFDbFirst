using System;
using System.Collections.Generic;

namespace EFDbFirst.Models;

public partial class Employee
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Position { get; set; } = null!;

    public decimal Salary { get; set; }

    public string Email { get; set; } = null!;

    public string Department { get; set; } = null!;
}
