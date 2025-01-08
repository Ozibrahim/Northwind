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
    public class OrderBs : IOrderBs
    {
        private readonly IOrderRepository _repo;
        public OrderBs(IOrderRepository repo)
        {
            //Validation


            _repo = repo;


            //Loglama
        }
        public Order Delete(Order entity)
        {
            return _repo.Delete(entity);
        }

        public Order Get(Expression<Func<Order, bool>> filter, bool noTracking = false, params string[] includelist)
        {
            return _repo.Get(filter, noTracking, includelist);
        }

        public List<Order> GetAll(Expression<Func<Order, bool>> filter = null, Expression<Func<Order, object>> orderby = null, Sorted sorted = Sorted.ASC, bool noTracking = false, params string[] includelist)
        {
            return _repo.GetAll(filter, orderby, sorted, noTracking, includelist);
        }

        public int GetCount(Expression<Func<Order, bool>> filter, params string[] includelist)
        {
            return _repo.GetCount(filter, includelist);
        }

        public Order Insert(Order entity)
        {
            return _repo.Insert(entity);
        }

        public Order Update(Order entity)
        {
            return _repo.Update(entity);
        }
    
    }
}
