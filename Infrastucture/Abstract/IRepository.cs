using Infrastucture.Enum;
using Infrastucture.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Infrastucture.Abstract
{
    public interface IRepository<T>
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null,Expression<Func<T,object>> orderby=null,Sorted sorted = Sorted.ASC, bool noTracking = false,params string[] includelist);
        T Get(Expression<Func<T, bool>> filter, bool noTracking = false,params string[] includelist);

        //T GetById(int Id);

        T Insert(T entity);
        T Delete(T entity);
        //T DeleteById(int Id);
        T Update(T entity);
        int GetCount(Expression<Func<T, bool>> filter, params string[] includelist);


    }
}
