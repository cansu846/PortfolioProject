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
    public class TestimonialManager : ITestimonialService
    {
        private readonly ITestimonialDal _testimonialDal;
        public TestimonialManager(ITestimonialDal testimonialDal)
        {
            _testimonialDal = testimonialDal;
        }
        public void Add(Testimonial entity)
        {
           _testimonialDal.Add(entity);   
        }

        public void delete(Testimonial entity)
        {
            _testimonialDal.Delete(entity);   
        }

        public List<Testimonial> GetAll()
        {
            return _testimonialDal.GetAll();  
        }

        public Testimonial GetByID(int id)
        {
           return _testimonialDal.GetByID(id);
        }

        public void update(Testimonial entity)
        {
            _testimonialDal.Update(entity);
        }
    }
}
