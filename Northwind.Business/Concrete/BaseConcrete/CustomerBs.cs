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
    public class CustomerBs : ICustomerBs
    {
        private readonly ICustomerRepository _repo;
        public CustomerBs(ICustomerRepository repo)
        {
            _repo = repo;
        }

        public Customer Delete(Customer entity)
        {
            return _repo.Delete(entity);
        }

        public Customer Get(Expression<Func<Customer, bool>> filter, bool noTracking = false, params string[] includelist)
        {
            return _repo.Get(filter, noTracking, includelist);
        }

        public List<Customer> GetAll(Expression<Func<Customer, bool>> filter = null, Expression<Func<Customer, object>> orderby = null, Sorted sorted = Sorted.ASC, bool noTracking = false, params string[] includelist)
        {
            return _repo.GetAll(filter,orderby,sorted,noTracking,includelist);
        }

        public int GetCount(Expression<Func<Customer, bool>> filter, params string[] includelist)
        {
            return _repo.GetCount(filter, includelist);
        }

        public Customer Insert(Customer entity)
        {
            return _repo.Insert(entity);
        }

        public Customer Update(Customer entity)
        {
            return _repo.Update(entity);
        }
    }
}
