using Infrastucture.Model;
using System;
using System.Collections.Generic;

namespace Northwind.Model.Entity;

public partial class QuarterlyOrder : BaseEntity
{
    public string? CustomerId { get; set; }

    public string? CompanyName { get; set; }

    public string? City { get; set; }

    public string? Country { get; set; }
}
