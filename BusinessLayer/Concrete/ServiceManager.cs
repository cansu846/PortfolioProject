using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ServiceManager : IServiceService
    {
        private readonly IServiceDal _serviceDal;
        public ServiceManager(IServiceDal serviceDal)
        {
            _serviceDal = serviceDal;
        }
        public void Add(Service entity)
        {
           _serviceDal.Add(entity);   
        }

        public void delete(Service entity)
        {
            _serviceDal.Delete(entity);   
        }

        public List<Service> GetAll()
        {
            return _serviceDal.GetAll();  
        }

        public Service GetByID(int id)
        {
           return _serviceDal.GetByID(id);
        }

        public void update(Service entity)
        {
            _serviceDal.Update(entity);
        }
    }
}
