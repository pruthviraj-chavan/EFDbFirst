using System;
using System.Collections.Generic;

namespace EFDbFirst.Models;

public partial class MarkSheet
{
    public int? RollNo { get; set; }

    public string? SubjectName { get; set; }

    public int? Marks { get; set; }
}
