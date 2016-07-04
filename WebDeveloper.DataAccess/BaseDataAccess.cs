﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace WebDeveloper.DataAccess
{
    public class BaseDataAccess<T> : IDataAccess<T> where T : class
    {
        public int Add(T entity)
        {
            using (var dbContext = new WebContextDb())
            {
                dbContext.Entry(entity).State = EntityState.Added;
                return dbContext.SaveChanges();
            }
        }
        public int Delete(T entity)
        {
            using (var dbContext = new WebContextDb())
            {
                dbContext.Entry(entity).State = EntityState.Deleted;
                return dbContext.SaveChanges();
            }
        }
        public List<T> GetList()
        {
            using (var dbContext = new WebContextDb())
            {
                return dbContext.Set<T>().ToList();
            }
        }
        public int Update(T entity)
        {
            using (var dbContext = new WebContextDb())
            {
                dbContext.Entry(entity).State = EntityState.Modified;
                return dbContext.SaveChanges();
            }
        }
    }
}
