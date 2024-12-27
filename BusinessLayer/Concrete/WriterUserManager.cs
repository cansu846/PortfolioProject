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
    public class WriterUserManager : IWriterUserService
    {
        private readonly IWriterUserDal _writerUserDal;
        public WriterUserManager(IWriterUserDal writerUserDal)
        {
          _writerUserDal = writerUserDal;
        }
        public void Add(WriterUser entity)
        {
            _writerUserDal.Add(entity);
        }

        public void delete(WriterUser entity)
        {
          _writerUserDal.Delete(entity);    
        }

        public List<WriterUser> GetAll()
        {
            return _writerUserDal.GetAll();
        }

        public WriterUser GetByID(int id)
        {
            return _writerUserDal.GetByID(id);
        }
        public void update(WriterUser entity)
        {
            _writerUserDal.Update(entity);
        }
    }
}
