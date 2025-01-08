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
    public class ProductBs : IProductBs
    {
        private readonly IProductRepository _repo;
        public ProductBs(IProductRepository repo)
        {
            //Validation


            _repo = repo;


            //Loglama
        }
        public Product Delete(Product entity)
        {
            return _repo.Delete(entity);
        }

        public Product Get(Expression<Func<Product, bool>> filter, bool noTracking = false, params string[] includelist)
        {
            return _repo.Get(filter, noTracking, includelist);
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null, Expression<Func<Product, object>> orderby = null, Sorted sorted = Sorted.ASC, bool noTracking = false, params string[] includelist)
        {
            return _repo.GetAll(filter, orderby, sorted, noTracking, includelist);
        }

        public int GetCount(Expression<Func<Product, bool>> filter, params string[] includelist)
        {
            return _repo.GetCount(filter, includelist);
        }

        public Product Insert(Product entity)
        {
            return _repo.Insert(entity);
        }

        public Product Update(Product entity)
        {
            return _repo.Update(entity);
        }
    
    }
}
