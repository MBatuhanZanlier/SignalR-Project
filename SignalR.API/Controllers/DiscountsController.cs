using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR.BussinessLayer.Abstract;
using SignalR.DtoLayer.DiscountDto;
using SignalR.EntityLayer.DAL.Entities;

namespace SignalR.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DiscountsController : ControllerBase
    {
        private readonly IDiscountService _DiscountService;
        private readonly IMapper _mapper;

        public DiscountsController(IDiscountService DiscountService, IMapper mapper)
        {
            _DiscountService = DiscountService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult DiscountList()
        {
            var value = _mapper.Map<List<ResultDiscountDto>>(_DiscountService.TGetListAll());
            return Ok(value);
        }
        [HttpPost]
        public IActionResult CreateDiscount(CreateDiscountDto DiscountDto)
        {
            _DiscountService.TAdd(new Discount()
            {
               Amount = DiscountDto.Amount, 
               Description= DiscountDto.Description,     
               ImageUrl=DiscountDto.ImageUrl,    
               Title= DiscountDto.Title,    
            });
            return Ok("Kategori Eklendi");

        }
        [HttpDelete]
        public IActionResult DeleteDiscount(int id)
        {
            var value = _DiscountService.TGetById(id);
            _DiscountService.TDelete(value);
            return Ok("Başarıyla Silindi");
        }

        [HttpGet("{id}")]
        public IActionResult GetDiscount(int id)
        {
            var value = _DiscountService.TGetById(id);
            return Ok(value);
        }
        [HttpPut]
        public IActionResult UpdateDiscount(UpdateDiscountDto DiscountDto)
        {
            _DiscountService.TUpdate(new Discount()
            {  
                Id=DiscountDto.Id,
                Amount = DiscountDto.Amount,
                Description = DiscountDto.Description,
                ImageUrl = DiscountDto.ImageUrl,
                Title = DiscountDto.Title,
              
            });
            return Ok("Başarıyla Güncellendi");
        }
    }
}
