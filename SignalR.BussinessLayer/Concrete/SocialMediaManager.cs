using SignalR.BussinessLayer.Abstract;
using SignalR.DataAccessLayer.Abstract;
using SignalR.EntityLayer.DAL.Entities;

namespace SignalR.BussinessLayer.Concrete
{
    public class SocialMediaManager : ISocialMediaService
    {
        private readonly ISocialMediaDal _socialmedia;

        public SocialMediaManager(ISocialMediaDal socialmedia)
        {
            _socialmedia = socialmedia;
        }

        public void TAdd(SocialMedia entity)
        {
           _socialmedia.Add(entity);
        }

        public void TDelete(SocialMedia entity)
        {
            _socialmedia.Delete(entity);
        }

        public SocialMedia TGetById(int id)
        {
          return _socialmedia.GetById(id);
        }

        public List<SocialMedia> TGetListAll()
        {
           return _socialmedia.GetListAll();
        }

        public void TUpdate(SocialMedia entity)
        {
           _socialmedia.Update(entity);
        }
    }
}
