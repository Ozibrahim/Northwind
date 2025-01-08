using Infrastucture.Concrete.EntityFramework;
using Infrastucture.Enum;
using Northwind.Data.Abstract;
using Northwind.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Data.Concrete.EntityFramework.Repository
{
    public class EfCategoryRepository : EfRepositoryBase<Category,NorthwindContext>,ICategoryRepository
    {
      
    }
}
