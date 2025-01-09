using SignalR.API.DAL.Entities;
using SignalR.DtoLayer.ProductDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.BussinessLayer.Abstract
{
    public interface IProductService:IGenericService<Product>
    {
        public List<ResultProductWithCategoryDto> TGetProductsWithCategory();

    }
}
