using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using WhatShouldWeEat.Core.DataAccess;

namespace WhatShouldWeEat.DataAccess.EntityFramework
{
    public class Repository<T> : RepositoryBase, IRepository<T> where T : class
    {
        private DbSet<T> _dbSet;

        public Repository()
        {
            _dbSet = dataContext.Set<T>();
        }


        public int Delete(T obj)
        {
            _dbSet.Remove(obj);
            return Save();
        }

        public T Find(Expression<Func<T, bool>> where)
        {
            return _dbSet.FirstOrDefault(where);
        }

        public int Insert(T obj)
        {
            dataContext.Set<T>().Add(obj);
            return Save();
        }

        public List<T> List()
        {
            return dataContext.Set<T>().ToList();
        }

        public List<T> List(Expression<Func<T, bool>> where)
        {
            return _dbSet.Where(where).ToList();
        }

        public IQueryable<T> ListQueryable()
        {
            return _dbSet.AsQueryable<T>();
        }

        public int Save()
        {
            return dataContext.SaveChanges();
        }

        public int Update(T obj)
        {
            return Save(); //  EF'te Update diye birşey yok, SaveChanges var.
        }
    }
}
