using AutoMapper;
using Infrastucture.CrossCuttingConcern.Converters;
using Infrastucture.Utility;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;
using Northwind.Business.Abstract;
using Northwind.Business.Concrete.BaseConcrete;
using Northwind.Model.Entity;
using Northwind.Model.ViewModel.Areas.Yonetici;
using System.Drawing;

namespace Northwind.WebCoreUI.Areas.Yonetici.Controllers
{
    [Area("Yonetici")]
    public class CategoryController : Controller
    {
        private readonly ICategoryBs _categoryBs;
        IMapper _mapper;
        public CategoryController(ICategoryBs categoryBs, IMapper mapper)
        {
            _categoryBs = categoryBs;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Add(IFormCollection data)
        {
            Category category = new Category();
            category.CategoryName = data["categoryname"];
            category.Description = data["description"];
            if (data.Files.Count > 1)
            {
                return Json(new { result = false, mesaj = "lütfen tek resim seçiniz..." });
            }
            else
            {
                IFormFile file = data.Files[0];


                int hata = 0;
                if (!file.ContentType.Contains("image/"))
                {
                    return Json(new { result = false, mesaj = "lütfen resim seçiniz..." });
                }
                else if (file.Length > 10485760)// 10MB dan büyükse
                {
                    return Json(new { result = false, mesaj = "lütfen 10MBdan küçük bir resim seçiniz..." });

                }
                else
                {
                    string extension = Path.GetExtension(file.FileName);
                    string newFileName = RandomValueGenerator.RandomFileGenerator(extension);
                    string uploadpath = Directory.GetCurrentDirectory() + "/wwwroot/adminassets/img/categoryimages/" + newFileName;
                    string dbpath = "/wwwroot/adminassets/img/categoryimages/" + newFileName;
                    using (FileStream fs = new FileStream(uploadpath, FileMode.Create))
                    {
                        file.CopyTo(fs);
                        Image image = Image.FromStream(fs);
                        category.Picture = Converters.ImageToByteArray(image);
                    }

                    using (FileStream fs = new FileStream(uploadpath, FileMode.Open))
                    {
                   
                        Image image = Image.FromStream(fs);
                        byte[] imagebyte = Converters.ImageToByteArray(image);
                        string base64Image = Convert.ToBase64String(imagebyte);
                        category.PicturePath = base64Image;
                       
                    }

                    //category.PicturePath = dbpath;
                    _categoryBs.Insert(category);

                }                
            }
            return Json(new { result = true,mesaj="Category başarıyla kaydedildi" });
        }
        public JsonResult tblCategories()
        {


            List<Category> categories = _categoryBs.GetAll();


            List<CategoryListVm> liste = _mapper.Map<List<CategoryListVm>>(categories);




            return Json(new { data = liste });
        }
    }
}
