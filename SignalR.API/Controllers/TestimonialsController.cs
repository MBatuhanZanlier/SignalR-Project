using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR.BussinessLayer.Abstract;
using SignalR.DtoLayer.TestimonialDto;
using SignalR.EntityLayer.DAL.Entities;

namespace SignalR.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestimonialsController : ControllerBase
    {

        private readonly ITestimonialService _TestimonialService;
        private readonly IMapper _mapper;

        public TestimonialsController(ITestimonialService TestimonialService, IMapper mapper)
        {
            _TestimonialService = TestimonialService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult TestimonialList()
        {
            var value = _mapper.Map<List<ResultTestimonialDto>>(_TestimonialService.TGetListAll());
            return Ok(value);
        }
        [HttpPost]
        public IActionResult CreateTestimonial(CreateTestimonialDto TestimonialDto)
        {
            _TestimonialService.TAdd(new Testimonial()
            {
             Comment=TestimonialDto.Comment, 
             ImageUrl=TestimonialDto.ImageUrl,   
             Name=TestimonialDto.Name, 
             Status= TestimonialDto.Status,  
             Title =TestimonialDto.Title,   
            });
            return Ok("Kategori Eklendi");

        }
        [HttpDelete]
        public IActionResult DeleteTestimonial(int id)
        {
            var value = _TestimonialService.TGetById(id);
            _TestimonialService.TDelete(value);
            return Ok("Başarıyla Silindi");
        }

        [HttpGet("{id}")]
        public IActionResult GetTestimonial(int id)
        {
            var value = _TestimonialService.TGetById(id);
            return Ok(value);
        }
        [HttpPut]
        public IActionResult UpdateTestimonial(UpdateTestimonialDto TestimonialDto)
        {
            _TestimonialService.TUpdate(new Testimonial()
            { 
                Id=TestimonialDto.Id,   
                Comment = TestimonialDto.Comment,
                ImageUrl = TestimonialDto.ImageUrl,
                Name = TestimonialDto.Name,
                Status = TestimonialDto.Status,
                Title = TestimonialDto.Title,
            });
            return Ok("Başarıyla Güncellendi");
        }
    }
}
