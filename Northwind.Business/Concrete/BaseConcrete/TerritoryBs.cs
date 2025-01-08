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
    public class TerritoryBs : ITerritoryBs
    {
        private readonly ITerritoryRepository _repo;
        public TerritoryBs(ITerritoryRepository repo)
        {
            //Validation


            _repo = repo;


            //Loglama
        }
        public Territory Delete(Territory entity)
        {
            return _repo.Delete(entity);
        }

        public Territory Get(Expression<Func<Territory, bool>> filter, bool noTracking = false, params string[] includelist)
        {
            return _repo.Get(filter, noTracking, includelist);
        }

        public List<Territory> GetAll(Expression<Func<Territory, bool>> filter = null, Expression<Func<Territory, object>> orderby = null, Sorted sorted = Sorted.ASC, bool noTracking = false, params string[] includelist)
        {
            return _repo.GetAll(filter, orderby, sorted, noTracking, includelist);
        }

        public int GetCount(Expression<Func<Territory, bool>> filter, params string[] includelist)
        {
            return _repo.GetCount(filter, includelist);
        }

        public Territory Insert(Territory entity)
        {
            return _repo.Insert(entity);
        }

        public Territory Update(Territory entity)
        {
            return _repo.Update(entity);
        }
    
    }
}
