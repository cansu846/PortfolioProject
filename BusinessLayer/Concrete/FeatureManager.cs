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
    public class FeatureManager : IFeatureService
    {
        private readonly IFeatureDal _featureDal;
        public FeatureManager(IFeatureDal featureDal)
        {
            _featureDal = featureDal;
        }
        public void Add(Feature entity)
        {
           _featureDal.Add(entity);   
        }

        public void delete(Feature entity)
        {
            _featureDal.Delete(entity);   
        }

        public List<Feature> GetAll()
        {
            return _featureDal.GetAll();  
        }

        public Feature GetByID(int id)
        {
           return _featureDal.GetByID(id);
        }

        public void update(Feature entity)
        {
            _featureDal.Update(entity);
        }
    }
}
