using SignalR.WebUI.Dtos.CategoryDto;

namespace SignalR.WebUI.Dtos.ProductDto
{
    public class ResultProductDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; } 
        public ResultCategoryDto Category { get; set; }
    }
}
