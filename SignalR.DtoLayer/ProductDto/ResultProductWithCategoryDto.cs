using SignalR.DtoLayer.CategoryDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.DtoLayer.ProductDto
{
    public class ResultProductWithCategoryDto : ResultProductDto
    {
        public ResultCategoryDto Category { get; set; }
    }
}
