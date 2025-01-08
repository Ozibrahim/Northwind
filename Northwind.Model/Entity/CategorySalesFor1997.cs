using Infrastucture.Model;
using System;
using System.Collections.Generic;

namespace Northwind.Model.Entity;

public partial class CategorySalesFor1997 : BaseEntity
{
    public string CategoryName { get; set; } = null!;

    public decimal? CategorySales { get; set; }
}
