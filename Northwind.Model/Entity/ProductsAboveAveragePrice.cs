using Infrastucture.Model;
using System;
using System.Collections.Generic;

namespace Northwind.Model.Entity;

public partial class ProductsAboveAveragePrice : BaseEntity
{
    public string ProductName { get; set; } = null!;

    public decimal? UnitPrice { get; set; }
}
