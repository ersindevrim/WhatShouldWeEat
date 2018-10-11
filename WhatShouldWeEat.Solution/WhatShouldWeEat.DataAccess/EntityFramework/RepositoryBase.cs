using System;
namespace WhatShouldWeEat.DataAccess.EntityFramework
{
    public class RepositoryBase
    {
        //singleton design pattern
        protected static DataContext dataContext;
        private static object _Lock = new object();

        protected RepositoryBase()
        {
            dataContext = CreateContext();
        }

        public static DataContext CreateContext()
        {
            if (dataContext == null)
            {
                lock (_Lock)
                {
                    if (dataContext == null)
                    {
                        dataContext = new DataContext();
                    }
                }
            }

            return dataContext;
        }
    }
}
