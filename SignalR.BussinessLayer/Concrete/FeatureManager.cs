using SignalR.API.DAL.Entities;
using SignalR.BussinessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.BussinessLayer.Concrete
{
    public class FeatureManager : IFeatureService
    { 
        private readonly IFeatureService _featureService;

        public FeatureManager(IFeatureService featureService)
        {
            _featureService = featureService;
        }

        public void TAdd(Feature entity)
        {
           _featureService.TAdd(entity);
        }

        public void TDelete(Feature entity)
        {
            _featureService.TDelete(entity);
        }

        public Feature TGetById(int id)
        {
            return _featureService.TGetById(id);    
        }

        public List<Feature> TGetListAll()
        {
            return _featureService.TGetListAll();
        }

        public void TUpdate(Feature entity)
        {
          _featureService.TUpdate(entity);
        }
    }
}
