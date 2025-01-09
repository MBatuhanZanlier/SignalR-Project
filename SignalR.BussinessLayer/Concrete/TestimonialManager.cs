using SignalR.BussinessLayer.Abstract;
using SignalR.DataAccessLayer.Abstract;
using SignalR.EntityLayer.DAL.Entities;

namespace SignalR.BussinessLayer.Concrete
{
    public class TestimonialManager : ITestimonialService
    {
        private readonly ITestimonialDal _testimonialdal;

        public TestimonialManager(ITestimonialDal testimonialdal)
        {
            _testimonialdal = testimonialdal;
        }

        public void TAdd(Testimonial entity)
        {
            _testimonialdal.Add(entity);
        }

        public void TDelete(Testimonial entity)
        {
            _testimonialdal.Delete(entity);
        }

        public Testimonial TGetById(int id)
        {
            return _testimonialdal.GetById(id);
        }

        public List<Testimonial> TGetListAll()
        {
           return _testimonialdal.GetListAll();
        }

        public void TUpdate(Testimonial entity)
        {
            _testimonialdal.Update(entity);
        } 

    }
}
