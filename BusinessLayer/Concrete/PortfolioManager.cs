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
    public class PortfolioManager : IPortfolioService
    {
        private readonly IPortfolioDal _portfolioDal;
        public PortfolioManager(IPortfolioDal portfolioDal)
        {
            _portfolioDal = portfolioDal;
        }
        public void Add(Portfolio entity)
        {
           _portfolioDal.Add(entity);   
        }

        public void delete(Portfolio entity)
        {
            _portfolioDal.Delete(entity);   
        }

        public List<Portfolio> GetAll()
        {
            return _portfolioDal.GetAll();  
        }

        public Portfolio GetByID(int id)
        {
           return _portfolioDal.GetByID(id);
        }

        public void update(Portfolio entity)
        {
            _portfolioDal.Update(entity);
        }
    }
}
