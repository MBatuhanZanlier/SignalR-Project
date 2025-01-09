using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR.API.DAL.Entities;
using SignalR.BussinessLayer.Abstract;
using SignalR.DtoLayer.SocialMediaDto;
using SignalR.EntityLayer.DAL.Entities;

namespace SignalR.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SocialMediasController : ControllerBase
    {
        private readonly ISocialMediaService _SocialMediaService;
        private readonly IMapper _mapper;

        public SocialMediasController(ISocialMediaService SocialMediaService, IMapper mapper)
        {
            _SocialMediaService = SocialMediaService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult SocialMediaList()
        {
            var value = _mapper.Map<List<ResultSocialMediaDto>>(_SocialMediaService.TGetListAll());
            return Ok(value);
        }
        [HttpPost]
        public IActionResult CreateSocialMedia(CreateSocialMediaDto SocialMediaDto)
        {
            _SocialMediaService.TAdd(new SocialMedia()
            {
         Icon=SocialMediaDto.Icon,
         Title=SocialMediaDto.Title, 
         Url=SocialMediaDto.Url,
            });
            return Ok("Kategori Eklendi");

        }
        [HttpDelete]
        public IActionResult DeleteSocialMedia(int id)
        {
            var value = _SocialMediaService.TGetById(id);
            _SocialMediaService.TDelete(value);
            return Ok("Başarıyla Silindi");
        }

        [HttpGet("{id}")]
        public IActionResult GetSocialMedia(int id)
        {
            var value = _SocialMediaService.TGetById(id);
            return Ok(value);
        }
        [HttpPut]
        public IActionResult UpdateSocialMedia(UpdateSocialMediaDto SocialMediaDto)
        {
            _SocialMediaService.TUpdate(new SocialMedia()
            { 
                Id=SocialMediaDto.Id,
                Icon = SocialMediaDto.Icon,
                Title = SocialMediaDto.Title,
                Url = SocialMediaDto.Url,
            });
            return Ok("Başarıyla Güncellendi");
        }
    }
}
