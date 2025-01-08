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
    public class ShipperBs : IShipperBs
    {
        private readonly IShipperRepository _repo;
        public ShipperBs(IShipperRepository repo)
        {
            //Validation


            _repo = repo;


            //Loglama
        }
        public Shipper Delete(Shipper entity)
        {
            return _repo.Delete(entity);
        }

        public Shipper Get(Expression<Func<Shipper, bool>> filter, bool noTracking = false, params string[] includelist)
        {
            return _repo.Get(filter, noTracking, includelist);
        }

        public List<Shipper> GetAll(Expression<Func<Shipper, bool>> filter = null, Expression<Func<Shipper, object>> orderby = null, Sorted sorted = Sorted.ASC, bool noTracking = false, params string[] includelist)
        {
            return _repo.GetAll(filter, orderby, sorted, noTracking, includelist);
        }

        public int GetCount(Expression<Func<Shipper, bool>> filter, params string[] includelist)
        {
            return _repo.GetCount(filter, includelist);
        }

        public Shipper Insert(Shipper entity)
        {
            return _repo.Insert(entity);
        }

        public Shipper Update(Shipper entity)
        {
            return _repo.Update(entity);
        }
    
    }
}
