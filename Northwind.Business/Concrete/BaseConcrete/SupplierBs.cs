using Infrastucture.Enum;
using Northwind.Business.Abstract;
using Northwind.Data.Abstract;
using Northwind.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Business.Concrete.BaseConcrete
{
    public class SupplierBs : ISupplierBs
    {
        private readonly ISupplierRepository _repo;
        public SupplierBs(ISupplierRepository repo)
        {
            //Validation


            _repo = repo;


            //Loglama
        }
        public Supplier Delete(Supplier entity)
        {
            return _repo.Delete(entity);
        }

        public Supplier Get(Expression<Func<Supplier, bool>> filter, bool noTracking = false, params string[] includelist)
        {
            return _repo.Get(filter, noTracking, includelist);
        }

        public List<Supplier> GetAll(Expression<Func<Supplier, bool>> filter = null, Expression<Func<Supplier, object>> orderby = null, Sorted sorted = Sorted.ASC, bool noTracking = false, params string[] includelist)
        {
            return _repo.GetAll(filter, orderby, sorted, noTracking, includelist);
        }

        public int GetCount(Expression<Func<Supplier, bool>> filter, params string[] includelist)
        {
            return _repo.GetCount(filter, includelist);
        }

        public Supplier Insert(Supplier entity)
        {
            return _repo.Insert(entity);
        }

        public Supplier Update(Supplier entity)
        {
            return _repo.Update(entity);
        }
    
    }
}
