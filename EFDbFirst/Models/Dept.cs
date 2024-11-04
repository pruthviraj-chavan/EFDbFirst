using System;
using System.Collections.Generic;

namespace EFDbFirst.Models;

public partial class Dept
{
    public int Id { get; set; }

    public string? DeptName { get; set; }

    public virtual ICollection<Emp> Emps { get; set; } = new List<Emp>();
}
