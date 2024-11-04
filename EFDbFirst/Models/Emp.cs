using System;
using System.Collections.Generic;

namespace EFDbFirst.Models;

public partial class Emp
{
    public int Id { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public int? DeptId { get; set; }

    public virtual Dept? Dept { get; set; }
}
