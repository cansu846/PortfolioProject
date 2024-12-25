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
    public class WriterMessageManager : IWriterMessageService
    {
        private readonly IWriterMessageDal _writerMessageDal;
        public WriterMessageManager(IWriterMessageDal writerMessageDal)
        {
            _writerMessageDal = writerMessageDal;
        }
        public void Add(WriterMessage entity)
        {
            throw new NotImplementedException();
        }

        public void delete(WriterMessage entity)
        {
            throw new NotImplementedException();
        }

        public List<WriterMessage> GetAll()
        {
            return _writerMessageDal.GetAll();  
        }

        public List<WriterMessage> GetByFilter(string value)
        {
           return  _writerMessageDal.GetByFilter(x=>x.Receiver == value);
        }

        public WriterMessage GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public void update(WriterMessage entity)
        {
            throw new NotImplementedException();
        }
    }
}
