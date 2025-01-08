using Infrastucture.Abstract;
using Infrastucture.Concrete.ADONET;
using Infrastucture.Concrete.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using Northwind.Business.Abstract;
using Northwind.Business.Concrete.BaseConcrete;
using Northwind.Business.Extension;
using Northwind.Data.Concrete.EntityFramework.Repository;
using Northwind.Model.Entity;
using System.Diagnostics;

namespace Northwind.WebCoreUI.Controllers
{
    public class HomeController : Controller
    {
        ICategoryBs _categoryBs;
        public HomeController(ICategoryBs categoryBs)
        {
            _categoryBs = categoryBs;
        }

        public IActionResult Index()
        {
            //------------------Infrastucture---------------------
            //EfRepositoryBase<Category, NorthwindContext> efcatbase = new EfRepositoryBase<Category, NorthwindContext>();
            //efcatbase.Insert(new Category(){ CategoryName="Sebzeler", Description="Elma,Domates,Marul"}); 

            //EfRepositoryBase<Order, NorthwindContext> eforderbase = new EfRepositoryBase<Order, NorthwindContext>();

            //----------------------DATA--------------------------
            //EntityFramework
            //IRepository<Category> cat = new EfRepositoryBase<Category,NorthwindContext>();
            //cat.Insert(new Category() { CategoryName = "Sebzeler", Description = "Elma,Domates,Marul" });
            //Adonet
            //IRepository<Category> cat = new AdoNetRepositoryBase<Category>();
            //---------------------------------------------------------------------
            //EfCategoryRepository repo = new EfCategoryRepository();
            //repo.Insert(new Category() { CategoryName = "Sebzeler", Description = "Elma,Domates,Marul" });

            //-------------------------Business----------------------------------

            //CategoryBs categoryBs = new CategoryBs(new EfCategoryRepository());
            //categoryBs.Insert(new Category() { CategoryName = "Sebzeler", Description = "Elma,Domates,Marul" });
            
            //------------------DI(Dependency Injection)--IO container--------------

            //_categoryBs.Insert(new Category() { CategoryName = "Sebzeler", Description = "Elma,Domates,Marul" });




            return View();
        }

        public IActionResult Privacy()
        {
            // int sonuc = 15.topla(5);  sonuc = 15+5=20 extension metot

            return View();

        }

   
    }
}
