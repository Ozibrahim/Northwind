using AutoMapper;
using Northwind.Model.Entity;
using Northwind.Model.ViewModel.Areas.Yonetici;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Business.MappingRule
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Product, ProductListVm>().ForMember(destination => destination.CategoryName, src => src.MapFrom(source => source.Category.CategoryName)).ForMember(destination => destination.SupplierName, src => src.MapFrom(source => source.Supplier.CompanyName)).ReverseMap();

            CreateMap<Product, ProductVm>().ReverseMap();


            CreateMap<Category,CategoryListVm>().ReverseMap();
        }
    }
}