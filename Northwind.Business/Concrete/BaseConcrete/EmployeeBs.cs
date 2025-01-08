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
    public class EmployeeBs : IEmployeeBs
    {
        private readonly IEmployeeRepository _repo;
        public EmployeeBs(IEmployeeRepository repo)
        {
            //Validation


            _repo = repo;


            //Loglama
        }
        public Employee Delete(Employee entity)
        {
            return _repo.Delete(entity);
        }

        public Employee Get(Expression<Func<Employee, bool>> filter, bool noTracking = false, params string[] includelist)
        {
            return _repo.Get(filter, noTracking, includelist);
        }

        public List<Employee> GetAll(Expression<Func<Employee, bool>> filter = null, Expression<Func<Employee, object>> orderby = null, Sorted sorted = Sorted.ASC, bool noTracking = false, params string[] includelist)
        {
            return _repo.GetAll(filter, orderby, sorted, noTracking, includelist);
        }

        public int GetCount(Expression<Func<Employee, bool>> filter, params string[] includelist)
        {
            return _repo.GetCount(filter, includelist);
        }

        public Employee Insert(Employee entity)
        {
            return _repo.Insert(entity);
        }

        public Employee Update(Employee entity)
        {
            return _repo.Update(entity);
        }
    
    }
}
