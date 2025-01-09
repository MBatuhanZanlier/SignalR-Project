using SignalR.API.DAL.Entities;
using SignalR.BussinessLayer.Abstract;
using SignalR.DataAccessLayer.Abstract;

namespace SignalR.BussinessLayer.Concrete
{
    public class ProductManager : IProductService
    {
        private readonly IProductDal _productdal;

        public ProductManager(IProductDal productdal)
        {
            _productdal = productdal;
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

        public void TUpdate(Product entity)
        {
            _productdal.Update(entity);
        }
    }
}
