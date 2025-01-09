using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR.API.DAL.Entities;
using SignalR.BussinessLayer.Abstract;
using SignalR.DtoLayer.FeatureDto;
using SignalR.EntityLayer.DAL.Entities;

namespace SignalR.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FeaturesController : ControllerBase
    {
        private readonly IFeatureService _FeatureService;
        private readonly IMapper _mapper;

        public FeaturesController(IFeatureService FeatureService, IMapper mapper)
        {
            _FeatureService = FeatureService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult FeatureList()
        {
            var value = _mapper.Map<List<ResultFeatureDto>>(_FeatureService.TGetListAll());
            return Ok(value);
        }
        [HttpPost]
        public IActionResult CreateFeature(CreateFeatureDto FeatureDto)
        {
            _FeatureService.TAdd(new Feature()
            {
             Description = FeatureDto.Description, 
             Description2 = FeatureDto.Description2, 
             Description3 = FeatureDto.Description3, 
             Title = FeatureDto.Title, 
             Title2 = FeatureDto.Title2, 
             Title3 = FeatureDto.Title3
            });
            return Ok("Kategori Eklendi");

        }
        [HttpDelete]
        public IActionResult DeleteFeature(int id)
        {
            var value = _FeatureService.TGetById(id);
            _FeatureService.TDelete(value);
            return Ok("Başarıyla Silindi");
        }

        [HttpGet("{id}")]
        public IActionResult GetFeature(int id)
        {
            var value = _FeatureService.TGetById(id);
            return Ok(value);
        }
        [HttpPut]
        public IActionResult UpdateFeature(UpdateFeatureDto FeatureDto)
        {
            _FeatureService.TUpdate(new Feature()
            { 
                Id=FeatureDto.Id,
                Description = FeatureDto.Description,
                Description2 = FeatureDto.Description2,
                Description3 = FeatureDto.Description3,
                Title = FeatureDto.Title,
                Title2 = FeatureDto.Title2,
                Title3 = FeatureDto.Title3
            });
            return Ok("Başarıyla Güncellendi");
        }
    }
}
