using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.EntityFramework
{
    public class EfWriterMessageDal : EfRepositoryDal<WriterMessage>, IWriterMessageDal
    {
        public List<WriterMessage> GetByFilter(Expression<Func<WriterMessage, bool>> filter)
        {
            var context = new Context();
            return context.Set<WriterMessage>().Where(filter).ToList();
        }
    }
}
