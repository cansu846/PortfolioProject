﻿using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.EntityFramework
{
    public class EfUserMessageDal : EfRepositoryDal<UserMessage>, IUserMessageDal
    {
        public List<UserMessage> GetUserMessageWithUser()
        {
            using var context = new Context();
            return context.UserMessages.Include(x => x.User).ToList(); 
        }
    }
}
