﻿using ContactForm.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Web;


namespace ContactForm.Repository
{
    public class AbstractRepository<T> where T : class
    { 
        public virtual void Create(T entity)
        {
            using(var context = new Models.AppContext())
            {
                context.Set<T>().Add(entity);
                context.SaveChanges();
            }
        }
        public virtual void Update(T entity)
        {
            using(var context = new Models.AppContext())
            {
                context.Entry(entity).State = EntityState.Modified;
                context.SaveChanges();
            }
        }
        public virtual List<T> GetWhere(Expression<Func<T,bool>> expression)
        {
            using (var context = new Models.AppContext())
            {
                var query = context.Set<T>().Where(expression);
                return query.ToList();
            }
        }

        public virtual void Delete(T entity)
        {
            using(var context = new Models.AppContext())
            {
                if(context.Entry(entity).State == EntityState.Detached)
                {
                    context.Set<T>().Attach(entity);
                }

                context.Set<T>().Remove(entity);
                context.SaveChanges();
            }
        }
    }
}