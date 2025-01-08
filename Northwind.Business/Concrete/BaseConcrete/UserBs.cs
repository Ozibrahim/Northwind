
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
    public class UserBs : IUserBs
    {
        private readonly IUserRepository _repo;
        public UserBs(IUserRepository repo)
        {
            //Validation


            _repo = repo;


            //Loglama
        }
        public User Delete(User entity)
        {
            return _repo.Delete(entity);
        }

        public User Get(Expression<Func<User, bool>> filter, bool noTracking = false, params string[] includelist)
        {
            return _repo.Get(filter, noTracking, includelist);
        }

        public List<User> GetAll(Expression<Func<User, bool>> filter = null, Expression<Func<User, object>> orderby = null, Sorted sorted = Sorted.ASC, bool noTracking = false, params string[] includelist)
        {
            return _repo.GetAll(filter, orderby, sorted, noTracking, includelist);
        }

        public int GetCount(Expression<Func<User, bool>> filter, params string[] includelist)
        {
            return _repo.GetCount(filter, includelist);
        }

        public User Insert(User entity)
        {
            return _repo.Insert(entity);
        }

        public User Update(User entity)
        {
            return _repo.Update(entity);
        }
    
    

    }
}
