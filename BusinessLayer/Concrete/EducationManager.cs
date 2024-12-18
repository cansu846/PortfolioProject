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
    public class EducationManager : IEducationService
    {
        private readonly IEducationDal _educationDal;
        public EducationManager(IEducationDal educationDal)
        {
            _educationDal = educationDal;
        }
        public void Add(Education entity)
        {
           _educationDal.Add(entity);   
        }

        public void delete(Education entity)
        {
            _educationDal.Delete(entity);   
        }

        public List<Education> GetAll()
        {
            return _educationDal.GetAll();  
        }

        public Education GetByID(int id)
        {
           return _educationDal.GetByID(id);
        }

        public void update(Education entity)
        {
            _educationDal.Update(entity);
        }
    }
}
