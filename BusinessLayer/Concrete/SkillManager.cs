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
    public class SkillManager : ISkillService
    {
        private readonly ISkillDal _skillDal;
        public SkillManager(ISkillDal skillDal)
        {
            _skillDal = skillDal;
        }
        public void Add(Skill entity)
        {
           _skillDal.Add(entity);   
        }

        public void delete(Skill entity)
        {
            _skillDal.Delete(entity);   
        }

        public List<Skill> GetAll()
        {
            return _skillDal.GetAll();  
        }

        public Skill GetByID(int id)
        {
           return _skillDal.GetByID(id);
        }

        public void update(Skill entity)
        {
            _skillDal.Update(entity);
        }
    }
}
