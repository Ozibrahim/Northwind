using Infrastucture.Model;
using System;
using System.Collections.Generic;

namespace Northwind.Model.Entity;

public partial class SalesTotalsByAmount : BaseEntity
{
    public decimal? SaleAmount { get; set; }

    public int OrderId { get; set; }

    public string CompanyName { get; set; } = null!;

    public DateTime? ShippedDate { get; set; }
}
