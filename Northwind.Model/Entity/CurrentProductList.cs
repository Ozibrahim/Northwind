using Infrastucture.Model;
using System;
using System.Collections.Generic;

namespace Northwind.Model.Entity;

public partial class CurrentProductList : BaseEntity
{
    public int ProductId { get; set; }

    public string ProductName { get; set; } = null!;
}
