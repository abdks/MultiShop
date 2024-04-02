using MultiShop.Cargo.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiShop.DataAccessLayer.Abstract
{
    public interface ICargoCustomerDal : IGenericDal<CargoCustomer>
    {
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<CargoCustomer> GetAll()
        {
            throw new NotImplementedException();
        }

        public CargoCustomer GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(CargoCustomer entity)
        {
            throw new NotImplementedException();
        }

        public void Update(CargoCustomer entity)
        {
            throw new NotImplementedException();
        }
    }
}
