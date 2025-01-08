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
    public class DenemeLogBs : IDenemeLogBs
    {
        private readonly IDenemeLogRepository _repo;
        public DenemeLogBs(IDenemeLogRepository repo)
        {
            //Validation


            _repo = repo;


            //Loglama
        }
        public DenemeLog Delete(DenemeLog entity)
        {
            return _repo.Delete(entity);
        }

        public DenemeLog Get(Expression<Func<DenemeLog, bool>> filter, bool noTracking = false, params string[] includelist)
        {
            return _repo.Get(filter, noTracking, includelist);
        }

        public List<DenemeLog> GetAll(Expression<Func<DenemeLog, bool>> filter = null, Expression<Func<DenemeLog, object>> orderby = null, Sorted sorted = Sorted.ASC, bool noTracking = false, params string[] includelist)
        {
            return _repo.GetAll(filter, orderby, sorted, noTracking, includelist);
        }

        public int GetCount(Expression<Func<DenemeLog, bool>> filter, params string[] includelist)
        {
            return _repo.GetCount(filter, includelist);
        }

        public DenemeLog Insert(DenemeLog entity)
        {
            return _repo.Insert(entity);
        }

        public DenemeLog Update(DenemeLog entity)
        {
            return _repo.Update(entity);
        }
    
    }
}
