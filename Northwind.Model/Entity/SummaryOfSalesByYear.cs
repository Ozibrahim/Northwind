using Infrastucture.Model;
using System;
using System.Collections.Generic;

namespace Northwind.Model.Entity;

public partial class SummaryOfSalesByYear : BaseEntity
{
    public DateTime? ShippedDate { get; set; }

    public int OrderId { get; set; }

    public decimal? Subtotal { get; set; }
}
