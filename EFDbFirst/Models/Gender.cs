using System;
using System.Collections.Generic;

namespace EFDbFirst.Models;

public partial class Gender
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public string Description { get; set; } = null!;

    public virtual ICollection<Student> Students { get; set; } = new List<Student>();
}
