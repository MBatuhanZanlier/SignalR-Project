using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR.BussinessLayer.Abstract;
using SignalR.DtoLayer.CategoryDto;
using SignalR.EntityLayer.DAL.Entities;

namespace SignalR.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    { 
        private readonly ICategoryService _categoryService;
        private readonly IMapper _mapper;
        public CategoriesController(ICategoryService categoryService, IMapper mapper)
        {
            _categoryService = categoryService;
            _mapper = mapper;
        }
        [HttpGet] 
        public IActionResult CategoryList()
        {
            var value = _mapper.Map<List<ResultCategoryDto>>(_categoryService.TGetListAll()); 
            return Ok(value);
        }
        [HttpPost]  
        public IActionResult CreateCategory(CreateCategoryDto categoryDto)  
        {
            _categoryService.TAdd(new Category()
            {
                Name = categoryDto.Name,
                Status = true
            });
            return Ok("Kategori Eklendi");
        
        }
        [HttpDelete] 
        public IActionResult DeleteCategory(int id)
        {
            var value=_categoryService.TGetById(id);     
            _categoryService.TDelete(value);
            return Ok("Başarıyla Silindi");
        }

        [HttpGet("{id}")] 
        public IActionResult GetCategory(int id)
        {
            var value=_categoryService.TGetById(id); 
            return Ok(value);
        }
        [HttpPut] 
        public IActionResult UpdateCategory(UpdateCategoryDto categoryDto)
        {
            _categoryService.TAdd(new Category()
            {
                Id = categoryDto.Id,
                Name = categoryDto.Name,
                Status = categoryDto.Status
            });
            return Ok("Başarıyla Güncellendi");
        }

        
    }
}
