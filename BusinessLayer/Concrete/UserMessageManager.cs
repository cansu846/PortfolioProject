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
    public class UserMessageManager : IUserMessageService
    {
        private readonly IUserMessageDal _userMessageDal;
        public UserMessageManager(IUserMessageDal userMessageDal)
        {
            _userMessageDal = userMessageDal;
        }
        public void Add(UserMessage entity)
        {
            _userMessageDal.Add(entity);
        }

        public void delete(UserMessage entity)
        {
            throw new NotImplementedException();
        }

        public List<UserMessage> GetAll()
        {
            throw new NotImplementedException();
        }

        public UserMessage GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<UserMessage> GetUserMessageWithUser()
        {
            return _userMessageDal.GetUserMessageWithUser();
        }

        public void update(UserMessage entity)
        {
            throw new NotImplementedException();
        }
    }
}
