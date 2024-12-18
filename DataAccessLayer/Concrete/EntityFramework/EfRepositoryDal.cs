using DataAccessLayer.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.EntityFramework
{
    public class EfRepositoryDal<T> : IRepositoryDal<T> where T : class
    {
        public void Add(T entity)
        {
            using var dbContext = new Context();
            dbContext.Add(entity);
            dbContext.SaveChanges();
        }

        public void Delete(T entity)
        {
            using var dbContext = new Context();
            dbContext.Remove(entity);
            dbContext.SaveChanges();    
        }

        public List<T> GetAll()
        {
            using var dbContext = new Context();
            return dbContext.Set<T>().ToList();
        }

        public T GetByID(int id)
        {
            using var dbContext = new Context();
            //Set<T>() metodu, Context nesnesinde bulunan
            //bir entity türüne ait veritabanı "tablosuna" erişim sağlar.
            //Find(id) ile belirtilen id değerine sahip bir kaydı bulmaya çalışır.
            return dbContext.Set<T>().Find(id);
        }

        public void Update(T entity)
        {
            using var dbContext = new Context();    
            dbContext.Update(entity);
            dbContext.SaveChanges();
        }
    }
}
