using Infrastucture.Model;
using System;
using System.Collections.Generic;

namespace Northwind.Model.Entity;

public partial class Region : BaseEntity
{
    public int RegionId { get; set; }

    public string RegionDescription { get; set; } = null!;

    public virtual ICollection<Territory> Territories { get; set; } = new List<Territory>();
}
