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
    public class AboutManager : IAboutService
    {
        private readonly IAboutDal _aboutDal;
        public AboutManager(IAboutDal aboutDal)
        {
            _aboutDal = aboutDal;
        }
        public void Add(About entity)
        {
           _aboutDal.Add(entity);   
        }

        public void delete(About entity)
        {
            _aboutDal.Delete(entity);   
        }

        public List<About> GetAll()
        {
            return _aboutDal.GetAll();  
        }

        public About GetByID(int id)
        {
           return _aboutDal.GetByID(id);
        }

        public void update(About entity)
        {
            _aboutDal.Update(entity);
        }
    }
}
