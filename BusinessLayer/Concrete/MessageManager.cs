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
    public class MessageManager : IMessageService
    {
        private readonly IMessageDal _messageDal;
        public MessageManager(IMessageDal messageDal)
        {
            _messageDal = messageDal;
        }
        public void Add(Message entity)
        {
           _messageDal.Add(entity);   
        }

        public void delete(Message entity)
        {
            _messageDal.Delete(entity);   
        }

        public List<Message> GetAll()
        {
            return _messageDal.GetAll();  
        }

        public Message GetByID(int id)
        {
           return _messageDal.GetByID(id);
        }

        public void update(Message entity)
        {
            _messageDal.Update(entity);
        }
    }
}
