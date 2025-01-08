using Microsoft.Extensions.DependencyInjection;
using Northwind.Business.Abstract;
using Northwind.Business.Concrete.BaseConcrete;
using Northwind.Data.Abstract;
using Northwind.Data.Concrete.EntityFramework.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Business.Extension
{
    public static class BusinessService
    {
        public static IServiceCollection AddBusinessService(this IServiceCollection service)
        {
            service.AddTransient<ICategoryBs, CategoryBs>();
            service.AddTransient<IProductBs, ProductBs>();
            service.AddTransient<IUserBs, UserBs>();
            service.AddTransient<ISupplierBs, SupplierBs>();
            
            return service;
        }

        //public static int topla(this int sayi1,int sayi2)
        //{
        //    return sayi1 + sayi2;
        //}

    }
}
