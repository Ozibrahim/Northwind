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
    public class RegionBs : IRegionBs
    {
        private readonly IRegionRepository _repo;
        public RegionBs(IRegionRepository repo)
        {
            //Validation


            _repo = repo;


            //Loglama
        }
        public Region Delete(Region entity)
        {
            return _repo.Delete(entity);
        }

        public Region Get(Expression<Func<Region, bool>> filter, bool noTracking = false, params string[] includelist)
        {
            return _repo.Get(filter, noTracking, includelist);
        }

        public List<Region> GetAll(Expression<Func<Region, bool>> filter = null, Expression<Func<Region, object>> orderby = null, Sorted sorted = Sorted.ASC, bool noTracking = false, params string[] includelist)
        {
            return _repo.GetAll(filter, orderby, sorted, noTracking, includelist);
        }

        public int GetCount(Expression<Func<Region, bool>> filter, params string[] includelist)
        {
            return _repo.GetCount(filter, includelist);
        }

        public Region Insert(Region entity)
        {
            return _repo.Insert(entity);
        }

        public Region Update(Region entity)
        {
            return _repo.Update(entity);
        }
    
    }
}
