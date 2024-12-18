using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class SocialMediaManager : ISocialMediaService
    {
        private readonly ISocialMediaDal _socialMediaDal;
        public SocialMediaManager(ISocialMediaDal socialMediaDal)
        {
            _socialMediaDal = socialMediaDal;
        }
        public void Add(SocialMedia entity)
        {
           _socialMediaDal.Add(entity);   
        }

        public void delete(SocialMedia entity)
        {
            _socialMediaDal.Delete(entity);   
        }

        public List<SocialMedia> GetAll()
        {
            return _socialMediaDal.GetAll();  
        }

        public SocialMedia GetByID(int id)
        {
           return _socialMediaDal.GetByID(id);
        }

        public void update(SocialMedia entity)
        {
            _socialMediaDal.Update(entity);
        }
    }
}
