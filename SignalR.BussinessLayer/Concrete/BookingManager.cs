using SignalR.BussinessLayer.Abstract;
using SignalR.DataAccessLayer.Abstract;
using SignalR.EntityLayer.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.BussinessLayer.Concrete
{
    public class BookingManager : IBookingService
    {
        private readonly IBookingDal _bookingdal;

        public BookingManager(IBookingDal bookingdal)
        {
            _bookingdal = bookingdal;
        }

        public void TAdd(Booking entity)
        {
           _bookingdal.Add(entity);
        }

        public void TDelete(Booking entity)
        {
           _bookingdal.Delete(entity);
        }

        public Booking TGetById(int id)
        {
           return _bookingdal.GetById(id);
        }

        public List<Booking> TGetListAll()
        {
           return _bookingdal.GetListAll();
        }

        public void TUpdate(Booking entity)
        {
           _bookingdal.Update(entity);
        }
    }
}
