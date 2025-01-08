using AutoMapper;
using FluentValidation;
using FluentValidation.AspNetCore;
using Northwind.Business.Abstract;
using Northwind.Business.Concrete.BaseConcrete;
using Northwind.Business.Extension;
using Northwind.Business.MappingRule;
using Northwind.Business.ValidationRule.Areas.Yonetici;
using Northwind.Data.Abstract;
using Northwind.Data.Concrete.EntityFramework.Repository;
using Northwind.Model.ViewModel.Areas.Yonetici;
using Northwind.WebCoreUI.Areas.Yonetici.Filters;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();


builder.Services.AddTransient<ICategoryRepository, EfCategoryRepository>();
builder.Services.AddTransient<ISupplierRepository, EfSupplierRepository>();
builder.Services.AddTransient<IProductRepository, EfProductRepository>();
builder.Services.AddTransient<IUserRepository, EfUserRepository>();


builder.Services.AddTransient<IHttpContextAccessor, HttpContextAccessor>();
builder.Services.AddTransient<ISessionManager, SessionManager>();

//builder.Services.AddTransient<ICategoryBs, CategoryBs>();
//builder.Services.AddTransient<IProductBs, ProductBs>();
//builder.Services.AddTransient<IUserBs, UserBs>();
builder.Services.AddSession();
builder.Services.AddBusinessService();

var mappingconfig = new MapperConfiguration(mc =>
{
    mc.AddProfile(new MappingProfile());
});

builder.Services.AddSingleton(mappingconfig);
builder.Services.AddAutoMapper(typeof(MappingProfile).Assembly);


//Validation
builder.Services.AddFluentValidationAutoValidation();
builder.Services.AddFluentValidationClientsideAdapters();
builder.Services.AddSingleton<IValidator<LoginVm>, LoginVmValidator>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseSession();

app.UseRouting();

app.UseAuthorization();

//app.MapControllerRoute(

//    name: "default",
//    pattern: "{controller=Home}/{action=Index}/{id?}");

app.UseEndpoints(endpoints =>
{

    endpoints.MapControllerRoute(
      name: "areas",
      pattern: "{area:exists}/{controller=User}/{action=Login}/{id?}"
    );

    endpoints.MapControllerRoute(
   name: "main",
   pattern: "{controller=Home}/{action=Index}/{id?}"
 );




});



app.Run();
