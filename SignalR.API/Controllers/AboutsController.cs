using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR.BussinessLayer.Abstract;
using SignalR.DtoLayer.AboutDto;

namespace SignalR.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutsController : ControllerBase
    { 
        private readonly IAboutService _aboutService;

        public AboutsController(IAboutService aboutService)
        {
            _aboutService = aboutService;
        }

        [HttpGet] 
        public IActionResult AboutList()
        {
            var values= _aboutService.TGetListAll(); 
            return Ok(values);
        }
        [HttpPost] 
        public IActionResult CreateAbout(CreateAboutDto createAboutDto)
        {
            _aboutService.TAdd(createAboutDto);
            return Ok("Başarıyla Eklendi");
        }
        [HttpDelete] 
        public IActionResult DeleteAbout(int id)
        {
            var value=_aboutService.TGetById(id);    
            _aboutService.TDelete(value);
            return Ok("Başarıyla Silindi"); 

        }
        [HttpPut] 
        public IActionResult UpdateAbout(UpdateAboutDto updateAboutDto)
        {
            _aboutService.TUpdate(updateAboutDto);
            return Ok("Hakkımda Alanı Güncellendi"); 

        }
        [HttpGet("{id}")] 
        public IActionResult GetAbout(int id)  
        {
           var value= _aboutService.TGetById(id);
            return Ok(value);
        }
    }
}
