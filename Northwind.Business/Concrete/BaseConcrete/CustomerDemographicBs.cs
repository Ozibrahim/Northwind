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
    public class CustomerDemographicBs : ICustomerDemographicBs
    {
        private readonly ICustomerDemographicRepository _repo;

        public CustomerDemographicBs(ICustomerDemographicRepository repo)
        {
            _repo = repo;
        }

        public CustomerDemographic Delete(CustomerDemographic entity)
        {
            return _repo.Delete(entity);
        }

        public CustomerDemographic Get(Expression<Func<CustomerDemographic, bool>> filter, bool noTracking = false, params string[] includelist)
        {
            return Get(filter, noTracking, includelist);
        }

        public List<CustomerDemographic> GetAll(Expression<Func<CustomerDemographic, bool>> filter = null, Expression<Func<CustomerDemographic, object>> orderby = null, Sorted sorted = Sorted.ASC, bool noTracking = false, params string[] includelist)
        {
            return GetAll(filter, orderby, sorted, noTracking, includelist);
        }

        public int GetCount(Expression<Func<CustomerDemographic, bool>> filter, params string[] includelist)
        {
            return _repo.GetCount(filter, includelist);
        }

        public CustomerDemographic Insert(CustomerDemographic entity)
        {
            return _repo.Insert(entity);
        }

        public CustomerDemographic Update(CustomerDemographic entity)
        {
            return _repo.Update(entity);
        }
    }
}
