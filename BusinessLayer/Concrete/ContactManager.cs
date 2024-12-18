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
    public class ContactManager : IContactService
    {
        private readonly IContactDal _contactDal;
        public ContactManager(IContactDal contactDal)
        {
            _contactDal = contactDal;
        }
        public void Add(Contact entity)
        {
           _contactDal.Add(entity);   
        }

        public void delete(Contact entity)
        {
            _contactDal.Delete(entity);   
        }

        public List<Contact> GetAll()
        {
            return _contactDal.GetAll();  
        }

        public Contact GetByID(int id)
        {
           return _contactDal.GetByID(id);
        }

        public void update(Contact entity)
        {
            _contactDal.Update(entity);
        }
    }
}
