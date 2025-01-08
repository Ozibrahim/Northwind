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
    public class CategoryBs : ICategoryBs
    {
        private readonly ICategoryRepository _repo;
        public CategoryBs(ICategoryRepository repo)
        {
            //Validation


            _repo = repo;


            //Loglama
        }
        public Category Delete(Category entity)
        {
            return _repo.Delete(entity);
        }

        public Category Get(Expression<Func<Category, bool>> filter, bool noTracking = false, params string[] includelist)
        {
            return _repo.Get(filter, noTracking, includelist);
        }

        public List<Category> GetAll(Expression<Func<Category, bool>> filter = null, Expression<Func<Category, object>> orderby = null, Sorted sorted = Sorted.ASC, bool noTracking = false, params string[] includelist)
        {
            return _repo.GetAll(filter, orderby, sorted, noTracking,includelist);
        }

        public int GetCount(Expression<Func<Category, bool>> filter, params string[] includelist)
        {
            return _repo.GetCount(filter, includelist);
        }

        public Category Insert(Category entity)
        {
            return _repo.Insert(entity);
        }

        public Category Update(Category entity)
        {
            return _repo.Update(entity);
        }
    }
}
