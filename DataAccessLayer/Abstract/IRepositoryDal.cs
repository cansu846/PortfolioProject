﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IRepositoryDal<T> where T : class
    {
        void Add(T entity); 
        void Update(T entity);
        void Delete(T entity);
        List<T> GetAll();
        T GetByID(int id);
    }
}
