using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR.BussinessLayer.Abstract;
using SignalR.DtoLayer.AboutDto;
using SignalR.DtoLayer.AboutDto;
using SignalR.EntityLayer.DAL.Entities;

namespace SignalR.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutsController : ControllerBase
    {
        private readonly IAboutService _AboutService;
        private readonly IMapper _mapper;

        public AboutsController(IAboutService AboutService, IMapper mapper)
        {
            _AboutService = AboutService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult AboutList()
        {
            var value = _mapper.Map<List<ResultAboutDto>>(_AboutService.TGetListAll());
            return Ok(value);
        }
        [HttpPost]
        public IActionResult CreateAbout(CreateAboutDto AboutDto)
        {
            _AboutService.TAdd(new About()
            {
                Description = AboutDto.Description,
                ImageUrl = AboutDto.ImageUrl,
                Title = AboutDto.Title,
            });
            return Ok("Kategori Eklendi");

        }
        [HttpDelete]
        public IActionResult DeleteAbout(int id)
        {
            var value = _AboutService.TGetById(id);
            _AboutService.TDelete(value);
            return Ok("Başarıyla Silindi");
        }

        [HttpGet("{id}")]
        public IActionResult GetAbout(int id)
        {
            var value = _AboutService.TGetById(id);
            return Ok(value);
        }
        [HttpPut]
        public IActionResult UpdateAbout(UpdateAboutDto AboutDto)
        {
            _AboutService.TUpdate(new About()
            {
                Id = AboutDto.Id,
                Description = AboutDto.Description,
                ImageUrl = AboutDto.ImageUrl,
                Title = AboutDto.Title,
            }); 
            return Ok("Başarıyla Güncellendi");
        }
    }
}
