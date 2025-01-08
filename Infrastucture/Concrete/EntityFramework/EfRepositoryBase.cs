using Infrastucture.Abstract;
using Infrastucture.Enum;
using Infrastucture.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Infrastucture.Concrete.EntityFramework
{
    public class EfRepositoryBase<TEntity, TContext> : IRepository<TEntity>
        where TContext : DbContext, new()
        where TEntity : class, new()
    {
        public TEntity Delete(TEntity entity)
        {
            using (TContext ctx = new TContext())
            {
                //DbSet<TEntity> listele ctx.Set<TEntity>(); burası Tentity tipinden context üzerindeki kolleksiyonu verir
                ctx.Set<TEntity>().Remove(entity);
                ctx.SaveChanges();
                return entity;
            }

        }

        //public TEntity DeleteById(int Id)
        //{
        //    using (TContext ctx = new TContext())
        //    {
        //        //DbSet<TEntity> listele = ctx.Set<TEntity>(); burası TEntity tipinden context üzerindeki kolleksiyonu verir
        //        TEntity entity = ctx.Set<TEntity>().SingleOrDefault(x => x.Id == Id);
        //        ctx.Set<TEntity>().Remove(entity);
        //        ctx.SaveChanges();
        //        return entity;
        //    }


        //}

        public TEntity Get(Expression<Func<TEntity, bool>> filter,bool noTracking=false, params string[] includelist)
        {
            using (TContext ctx = new TContext())
            {
                IQueryable<TEntity> query = ctx.Set<TEntity>();
                if (includelist != null && includelist.Length > 0)
                {
                    for (int i = 0; i < includelist.Length; i++)
                    {
                        query = query.Include(includelist[i]);
                    }
                }
                if (noTracking)
                {
                return query.AsNoTracking().SingleOrDefault(filter);
                }
                else
                {
                return query.SingleOrDefault(filter);
                }

            }
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null, Expression<Func<TEntity, object>> orderby = null, Sorted sorted = Sorted.ASC, bool noTracking = false, params string[] includelist)
        {
            using (TContext ctx = new TContext())
            {

                IQueryable<TEntity> query = ctx.Set<TEntity>();
                if (filter != null)
                {
                    query = query.Where(filter);
                }

                if (includelist != null)
                {
                    for (int i = 0; i < includelist.Length; i++)
                    {
                        query = query.Include(includelist[i]);
                    }
                }

                if (orderby != null && sorted == Sorted.ASC)
                {
                    query = query.OrderBy(orderby);
                }
                else if (orderby != null && sorted == Sorted.DESC)
                {
                    query.OrderByDescending(orderby);
                }

                if (noTracking)
                {
                    return query.AsNoTracking().ToList();
                }
                else
                {
                    return query.ToList();
                }

            }

        }

        public int GetCount(Expression<Func<TEntity, bool>> filter = null,params string[] includelist)
        {
            using (TContext ctx = new TContext())
            {

                IQueryable<TEntity> query = ctx.Set<TEntity>();         

                if (includelist != null)
                {
                    for (int i = 0; i < includelist.Length; i++)
                    {
                        query = query.Include(includelist[i]);
                    }
                }

       

                return query.Count(filter);

            }

        }

        //public TEntity GetById(int Id)
        //{
        //    return Get(x => x.Id == Id);
        //}

        public TEntity Insert(TEntity entity)
        {
            using (TContext ctx = new TContext())
            {

                ctx.Set<TEntity>().Add(entity);
                ctx.SaveChanges();
                return entity;
            };
        }

        public TEntity Update(TEntity entity)
        {
            using (TContext ctx = new TContext())
            {
                //ctx.Attach(entity);
                //ctx.Entry(entity).State=EntityState.Modified;
                //ctx.SaveChanges();
                //return entity;


                ctx.Set<TEntity>().Update(entity);
                ctx.SaveChanges();
                return entity;
            };
        }
    }

}
