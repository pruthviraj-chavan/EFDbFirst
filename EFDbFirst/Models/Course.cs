using System;
using System.Collections.Generic;

namespace EFDbFirst.Models;

public partial class Course
{
    public int CourseId { get; set; }

    public string? CourseName { get; set; }

    public int? Credit { get; set; }
}
