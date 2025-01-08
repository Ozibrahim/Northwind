using Microsoft.AspNetCore.Mvc.Rendering;
using Northwind.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Model.ViewModel.Areas.Yonetici
{
    public class ProductVm
    {
        public List<ProductListVm> ProductList { get; set; }

        //public ProductListVm ModalUrunEkle { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; } = null!;
        public int? SupplierId { get; set; }
        public int? CategoryId { get; set; }
        public decimal? UnitPrice { get; set; }
        public short? UnitsInStock { get; set; }
  
        //public List<Category> CategoryList { get; set; }
        //public List<Supplier> SupplierList { get; set; }

        public List<SelectListItem> CategoryListItem { get; set; }
        public List<SelectListItem> SupplierListItem { get; set; }

        public int GProductId { get; set; }
        public string GProductName { get; set; } = null!;
        public int? GSupplierId { get; set; }
        public int? GCategoryId { get; set; }
        public decimal? GUnitPrice { get; set; }
        public short? GUnitsInStock { get; set; }
        public string GCategoryName { get; set; }
        public string GSupplierName { get; set; }


    }
}
