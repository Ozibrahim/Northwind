using Infrastucture.Model;
using System;
using System.Collections.Generic;

namespace Northwind.Model.Entity;

public partial class OrderSubtotal : BaseEntity
{
    public int OrderId { get; set; }

    public decimal? Subtotal { get; set; }
}
