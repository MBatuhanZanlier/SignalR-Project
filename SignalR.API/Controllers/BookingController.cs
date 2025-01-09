using Microsoft.AspNetCore.Mvc;
using SignalR.BussinessLayer.Abstract;
using SignalR.DtoLayer.BookingDto;
using SignalR.EntityLayer.DAL.Entities;

namespace SignalR.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        private readonly IBookingService _bookingService;

        public BookingController(IBookingService bookingService)
        {
            _bookingService = bookingService;
        }

        [HttpGet]
        public IActionResult BookingList()
        {
            var values = _bookingService.TGetListAll();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult CreateBooking(CreateBookingDto createBookingDto)
        {
            _bookingService.TAdd(new Booking
            {
               
                Date = DateTime.Now,
                Mail = createBookingDto.Mail,
                Name = createBookingDto.Name,
                PersonCount = createBookingDto.PersonCount,
                Phone = createBookingDto.Phone
            });
            return Ok("Rezervasyon Yapıldı");
        }
        [HttpDelete]
        public IActionResult DeleteBooking(int id)
        {

            var values = _bookingService.TGetById(id);
            _bookingService.TDelete(values);
            return Ok("Başarıyla Silindi");
        }

        [HttpPut]
        public IActionResult UpdateBooking(UpdateBookingDto updateBookingDto)
        {
            _bookingService.TUpdate(new Booking()
            {
                Id = updateBookingDto.Id,
                Date = DateTime.Now,
                Mail = updateBookingDto.Mail,
                Name = updateBookingDto.Name,
                PersonCount = updateBookingDto.PersonCount,
                Phone = updateBookingDto.Phone
            });
            return Ok("Başarıyla Güncellendi");
        }

        [HttpGet("{id}")]
        public IActionResult GetBooking(int id)
        {
            var values = _bookingService.TGetById(id);
            return Ok(values);
        }
    }
}
