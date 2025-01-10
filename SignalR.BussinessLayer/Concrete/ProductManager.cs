using AutoMapper;
using SignalR.API.DAL.Entities;
using SignalR.BussinessLayer.Abstract;
using SignalR.DataAccessLayer.Abstract;
using SignalR.DtoLayer.ProductDto;

namespace SignalR.BussinessLayer.Concrete
{
    public class ProductManager : IProductService
    {
        private readonly IProductDal _productdal;
        private readonly IMapper _mapper;
        public ProductManager(IProductDal productdal, IMapper mapper)
        {
            _productdal = productdal;
            _mapper = mapper;
        }
        public void TAdd(Product entity)
        {
           _productdal.Add(entity);
        }
        public void TDelete(Product entity)
        { 
            _productdal.Delete(entity);
        }
        public Product TGetById(int id)
        {
           return _productdal.GetById(id);
        }
        public List<Product> TGetListAll()
        {
           return _productdal.GetListAll();
        }
        public List<ResultProductWithCategoryDto> TGetProductsWithCategory()
        {  
            var product=_productdal.GetProductsWithCategory();
            var productDto = _mapper.Map<List<ResultProductWithCategoryDto>>(product); 
            return productDto;
            
        }
        public void TUpdate(Product entity)
        {
            _productdal.Update(entity);
        }
    }
}
