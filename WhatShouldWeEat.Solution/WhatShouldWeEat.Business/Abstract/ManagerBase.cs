using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using WhatShouldWeEat.Core.DataAccess;
using WhatShouldWeEat.DataAccess.EntityFramework;


namespace WhatShouldWeEat.Business.Abstract
{
    public class ManagerBase<T> : IRepository<T> where T : class 
    {
        private Repository<T> _repository = new Repository<T>();

        public int Delete(T obj)
        {
            return _repository.Delete(obj);
        }

        public T Find(Expression<Func<T, bool>> where)
        {
            return _repository.Find(where);
        }

        public int Insert(T obj)
        {
            return _repository.Insert(obj);
        }

        public List<T> List()
        {
            return _repository.List();
        }

        public List<T> List(Expression<Func<T, bool>> where)
        {
            return _repository.List(where);
        }

        public IQueryable<T> ListQueryable()
        {
            return _repository.ListQueryable();
        }

        public int Save()
        {
            return _repository.Save();
        }

        public int Update(T obj)
        {
            return _repository.Update(obj);
        }
    }
}
