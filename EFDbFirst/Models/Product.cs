using System;
using System.Collections.Generic;

namespace EFDbFirst.Models;

public partial class Product
{
    public string? Name { get; set; }

    public int? Price { get; set; }

    public int Id { get; set; }
}
