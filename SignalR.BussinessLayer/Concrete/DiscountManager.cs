using SignalR.BussinessLayer.Abstract;
using SignalR.EntityLayer.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.BussinessLayer.Concrete
{
    public class DiscountManager : IDiscountService
    { 
        private readonly IDiscountService _discountService;

        public DiscountManager(IDiscountService discountService)
        {
            _discountService = discountService;
        }

        public void TAdd(Discount entity)
        {
           _discountService.TAdd(entity);
        }

        public void TDelete(Discount entity)
        {
         _discountService.TDelete(entity);
        }

        public Discount TGetById(int id)
        {
           return _discountService.TGetById(id);
        }

        public List<Discount> TGetListAll()
        {
            return _discountService.TGetListAll();
        }

        public void TUpdate(Discount entity)
        {
           _discountService.TUpdate(entity);
        }
    }
}
