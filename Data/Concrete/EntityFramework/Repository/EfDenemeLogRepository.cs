using Infrastucture.Concrete.EntityFramework;
using Northwind.Data.Abstract;
using Northwind.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Data.Concrete.EntityFramework.Repository
{
    public class EfDenemeLogRepository:EfRepositoryBase<DenemeLog,NorthwindContext>,IDenemeLogRepository
    {
    }
}
