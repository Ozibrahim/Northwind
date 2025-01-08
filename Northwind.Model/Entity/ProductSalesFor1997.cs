using Infrastucture.Model;
using System;
using System.Collections.Generic;

namespace Northwind.Model.Entity;

public partial class ProductSalesFor1997 : BaseEntity
{
    public string CategoryName { get; set; } = null!;

    public string ProductName { get; set; } = null!;

    public decimal? ProductSales { get; set; }
}
