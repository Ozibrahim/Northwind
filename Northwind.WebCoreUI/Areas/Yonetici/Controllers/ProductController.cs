using AutoMapper;
using Infrastucture.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Northwind.Business.Abstract;
using Northwind.Business.Concrete.BaseConcrete;
using Northwind.Model.Entity;
using Northwind.Model.ViewModel.Areas.Yonetici;
using Northwind.WebCoreUI.Areas.Yonetici.Filters;


namespace Northwind.WebCoreUI.Areas.Yonetici.Controllers
{
    [Area("Yonetici")]
    [AktifYoneticiFilter]
    public class ProductController : Controller
    {
        IProductBs _productBs;
        IMapper _mapper;
        ICategoryBs _categoryBs;
        ISupplierBs _supplierBs;
        public ProductController(IProductBs productBs, IMapper mapper, ICategoryBs categoryBs, ISupplierBs supplierBs)
        {
            _productBs = productBs;
            _mapper = mapper;
            _categoryBs = categoryBs;
            _supplierBs = supplierBs;
        }
      
        public IActionResult Index()
        {


            List<Product> products = _productBs.GetAll(null, null, Infrastucture.Enum.Sorted.ASC, false, "Category", "Supplier");
            //1.yol
            //List<ProductListVm> liste = new List<ProductListVm>();
            //foreach (Product item in products)
            //{
            //    ProductListVm vm = new ProductListVm();
            //    vm.ProductId = item.ProductId;
            //    vm.ProductName = item.ProductName;
            //    vm.SupplierId = item.SupplierId;
            //    vm.CategoryId = item.CategoryId;
            //    vm.UnitPrice = item.UnitPrice;
            //    vm.UnitsInStock = item.UnitsInStock;
            //    vm.CategoryName = item.Category==null?"":item.Category.CategoryName;
            //    vm.SupplierName = item.Supplier == null ? "" : item.Supplier.ContactName;

            //    liste.Add(vm);
            //}

            //2.yol
            //List<ProductListVm> liste = products.Select(x=>new ProductListVm() 
            //{ 
            //    CategoryId =x.CategoryId,
            //    CategoryName= x.Category.CategoryName,
            //    ProductId = x.ProductId,
            //    ProductName = x.ProductName,
            //    UnitPrice = x.UnitPrice,
            //    SupplierId = x.SupplierId,
            //    SupplierName = x.Supplier.ContactName,
            //    UnitsInStock = x.UnitsInStock
            //}).ToList();


            //_mapper.Map<destination>(source);


            List<ProductListVm> liste = _mapper.Map<List<ProductListVm>>(products);

            ProductVm model = new ProductVm();
            model.ProductList = liste;
            //model.CategoryList = _categoryBs.GetAll();
            model.CategoryListItem = _categoryBs.GetAll().Select(x => new SelectListItem() { Text = x.CategoryName, Value = x.CategoryId.ToString() }).ToList();
            model.SupplierListItem = _supplierBs.GetAll().Select(x => new SelectListItem() { Text = x.CompanyName, Value = x.SupplierId.ToString() }).ToList();

            return View(model);
        }

      
        public JsonResult tblProducts()
        {


            List<Product> products = _productBs.GetAll(null, null, Infrastucture.Enum.Sorted.ASC, false, "Category", "Supplier");


            List<ProductListVm> liste = _mapper.Map<List<ProductListVm>>(products);

          


            return Json(new {data=liste});
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public JsonResult Add(ProductVm urun)
        {
            Product pr = _mapper.Map<Product>(urun);
            _productBs.Insert(pr);
            
            List<Product> products = _productBs.GetAll(null, null, Infrastucture.Enum.Sorted.ASC, false, "Category", "Supplier");
            List<ProductListVm> liste = _mapper.Map<List<ProductListVm>>(products);

            return Json(new AjaxResponse<List<ProductListVm>>(true,liste,"Ürün Başarıyla Eklendi") );
        }
        [HttpPost]
        public JsonResult GetProduct(int id)
        {

            Product product = _productBs.Get(x => x.ProductId == id,false,"Category","Supplier");
            ProductVm prvm = _mapper.Map<ProductVm>(product);
            return Json(new AjaxResponse<ProductVm>(true,prvm));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public JsonResult Update(ProductVm product)
        {

            Product pr = _productBs.Get(x => x.ProductId == product.ProductId);
            pr.ProductId = product.ProductId;
            pr.ProductName = product.ProductName;
            pr.UnitPrice = product.UnitPrice;
            pr.UnitsInStock = product.UnitsInStock;
            pr.SupplierId = product.SupplierId;
            pr.CategoryId = product.CategoryId;
            _productBs.Update(pr);


            
            return Json(new AjaxResponse<ProductVm>(true, product, product.ProductName + " ürünü başarıyla güncellendi."));
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public JsonResult Delete(int id)
        {
            Product product = _productBs.Get(x => x.ProductId == id);
    
            _productBs.Delete(product);



            return Json(new AjaxResponse<Product>(true, product, product.ProductName + " ürünü başarıyla silindi."));
        }


    }

}