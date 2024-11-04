using System;
using System.Collections.Generic;

namespace EFDbFirst.Models;

public partial class NewStduent
{
    public int StudentId { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public DateOnly? EnrollmentDate { get; set; }

    public string? Major { get; set; }
}
