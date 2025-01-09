using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SignalR.BussinessLayer.Abstract;
using SignalR.DtoLayer.ProductDto;
using SignalR.API.DAL.Entities;

namespace SignalR.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _ProductService;
        private readonly IMapper _mapper;

        public ProductsController(IProductService ProductService, IMapper mapper)
        {
            _ProductService = ProductService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult ProductList()
        {
            var value = _ProductService.TGetProductsWithCategory();
            return Ok(value);
        }
        [HttpGet("ProductListWithCategory")]
        public IActionResult ProductListWithCategory()
        {
            var value = _mapper.Map<List<ResultProductWithCategoryDto>>(_ProductService.TGetProductsWithCategory()); 
            return Ok(value);
        }

        [HttpPost]
        public IActionResult CreateProduct(CreateProductDto ProductDto)
        {
            _ProductService.TAdd(new Product()
            {
                Description=ProductDto.Description, 
                Name=ProductDto.Name,
               Price=ProductDto.Price, 
            }); 
            return Ok("Kategori Eklendi");

        }
        [HttpDelete]
        public IActionResult DeleteProduct(int id)
        {
            var value = _ProductService.TGetById(id);
            _ProductService.TDelete(value);
            return Ok("Başarıyla Silindi");
        }

        [HttpGet("{id}")]
        public IActionResult GetProduct(int id)
        {
            var value = _ProductService.TGetById(id);
            return Ok(value);
        }
        [HttpPut]
        public IActionResult UpdateProduct(UpdateProductDto ProductDto)
        {
            _ProductService.TUpdate(new Product()
            {
                Description = ProductDto.Description, 
                Name = ProductDto.Name, 
                Price = ProductDto.Price, 
                ImageUrl = ProductDto.ImageUrl, 
                Id=ProductDto.ProductId
            }) ;
            return Ok("Başarıyla Güncellendi");
        }
    }
}
