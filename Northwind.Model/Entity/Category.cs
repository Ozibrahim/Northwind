using Infrastucture.Model;
using System;
using System.Collections.Generic;

namespace Northwind.Model.Entity;

public partial class Category:BaseEntity
{
    public int CategoryId { get; set; }

    public string CategoryName { get; set; } = null!;

    public string? Description { get; set; }

    public byte[]? Picture { get; set; }
    public string? PicturePath { get; set; }

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
