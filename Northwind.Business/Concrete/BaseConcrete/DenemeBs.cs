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
    public class DenemeBs : IDenemeBs
    {
        private readonly IDenemeRepository _repo;
        public DenemeBs(IDenemeRepository repo)
        {
            //Validation


            _repo = repo;


            //Loglama
        }
        public Deneme Delete(Deneme entity)
        {
            return _repo.Delete(entity);
        }

        public Deneme Get(Expression<Func<Deneme, bool>> filter, bool noTracking = false, params string[] includelist)
        {
            return _repo.Get(filter, noTracking, includelist);
        }

        public List<Deneme> GetAll(Expression<Func<Deneme, bool>> filter = null, Expression<Func<Deneme, object>> orderby = null, Sorted sorted = Sorted.ASC, bool noTracking = false, params string[] includelist)
        {
            return _repo.GetAll(filter, orderby, sorted, noTracking, includelist);
        }

        public int GetCount(Expression<Func<Deneme, bool>> filter, params string[] includelist)
        {
            return _repo.GetCount(filter, includelist);
        }

        public Deneme Insert(Deneme entity)
        {
            return _repo.Insert(entity);
        }

        public Deneme Update(Deneme entity)
        {
            return _repo.Update(entity);
        }
    
    }
}
