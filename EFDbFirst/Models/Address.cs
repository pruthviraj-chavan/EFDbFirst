using System;
using System.Collections.Generic;

namespace EFDbFirst.Models;

public partial class Address
{
    public int Id { get; set; }

    public string PhysicalAddress { get; set; } = null!;

    public string PostalAddress { get; set; } = null!;

    public int StudentId { get; set; }

    public virtual Student Student { get; set; } = null!;
}
