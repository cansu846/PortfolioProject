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
    public class ExperienceManager : IExperienceService
    {
        private readonly IExperienceDal _experienceDal;
        public ExperienceManager(IExperienceDal experienceDal)
        {
            _experienceDal = experienceDal;
        }
        public void Add(Experience entity)
        {
           _experienceDal.Add(entity);   
        }

        public void delete(Experience entity)
        {
            _experienceDal.Delete(entity);   
        }

        public List<Experience> GetAll()
        {
            return _experienceDal.GetAll();  
        }

        public Experience GetByID(int id)
        {
           return _experienceDal.GetByID(id);
        }

        public void update(Experience entity)
        {
            _experienceDal.Update(entity);
        }
    }
}
