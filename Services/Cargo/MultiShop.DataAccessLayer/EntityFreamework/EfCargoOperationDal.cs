using MultiShop.Cargo.EntityLayer.Concrete;
using MultiShop.DataAccessLayer.Abstract;
using MultiShop.DataAccessLayer.Concrete;
using MultiShop.DataAccessLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiShop.DataAccessLayer.EntityFreamework
{
    public class EfCargoOperationDal:GenericRepository<CargoOperation>,ICargoOperationDal
    {
        public EfCargoOperationDal(CargoContext context) : base(context) 
        {
            
        }
    }
}
