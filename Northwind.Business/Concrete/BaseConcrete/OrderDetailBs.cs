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
    public class OrderDetailBs : IOrderDetailBs
    {
        private readonly IOrderDetailRepository _repo;
        public OrderDetailBs(IOrderDetailRepository repo)
        {
            //Validation


            _repo = repo;


            //Loglama
        }
        public OrderDetail Delete(OrderDetail entity)
        {
            return _repo.Delete(entity);
        }

        public OrderDetail Get(Expression<Func<OrderDetail, bool>> filter, bool noTracking = false, params string[] includelist)
        {
            return _repo.Get(filter, noTracking, includelist);
        }

        public List<OrderDetail> GetAll(Expression<Func<OrderDetail, bool>> filter = null, Expression<Func<OrderDetail, object>> orderby = null, Sorted sorted = Sorted.ASC, bool noTracking = false, params string[] includelist)
        {
            return _repo.GetAll(filter, orderby, sorted, noTracking, includelist);
        }

        public int GetCount(Expression<Func<OrderDetail, bool>> filter, params string[] includelist)
        {
            return _repo.GetCount(filter, includelist);
        }

        public OrderDetail Insert(OrderDetail entity)
        {
            return _repo.Insert(entity);
        }

        public OrderDetail Update(OrderDetail entity)
        {
            return _repo.Update(entity);
        }
    
    }
}
