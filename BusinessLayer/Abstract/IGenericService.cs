using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IGenericService<T> where T : class
    {
        void Add(T entity);
        void delete(T entity);
        void update(T entity);
        T GetByID(int id);
        List<T> GetAll();
    }
}
