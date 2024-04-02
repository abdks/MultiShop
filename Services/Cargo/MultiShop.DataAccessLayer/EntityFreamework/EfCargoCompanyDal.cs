
using MultiShop.Cargo.EntityLayer.Concrete;
using MultiShop.DataAccessLayer.Abstract;
using MultiShop.DataAccessLayer.Concrete;
using MultiShop.DataAccessLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiShop.Cargo.DataAccessLayer.EntityFramework
{
    public class EfCargoCompanyDal : GenericRepository<CargoCompany>, ICargoCompanyDal
    {
        public EfCargoCompanyDal(CargoContext context) : base(context)
        {

        }
    }
}