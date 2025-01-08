using Infrastucture.Model;
using System;
using System.Collections.Generic;

namespace Northwind.Model.Entity;

public partial class VwGetir : BaseEntity
{
    public int Id { get; set; }

    public string Adi { get; set; } = null!;

    public string Soyadı { get; set; } = null!;

    public string Katergoriadi { get; set; } = null!;

    public int? SatışSayısı { get; set; }
}
