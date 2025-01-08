using Infrastucture.Model;
using System;
using System.Collections.Generic;

namespace Northwind.Model.Entity;

public partial class CustomerAndSuppliersByCity : BaseEntity
{
    public string? City { get; set; }

    public string CompanyName { get; set; } = null!;

    public string? ContactName { get; set; }

    public string Relationship { get; set; } = null!;
}
