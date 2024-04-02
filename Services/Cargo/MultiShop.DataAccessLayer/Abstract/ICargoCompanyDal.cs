using MultiShop.Cargo.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiShop.DataAccessLayer.Abstract
{
    public interface ICargoCompanyDal : IGenericDal<CargoCompany>
    {
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<CargoCompany> GetAll()
        {
            throw new NotImplementedException();
        }

        public CargoCompany GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(CargoCompany entity)
        {
            throw new NotImplementedException();
        }

        public void Update(CargoCompany entity)
        {
            throw new NotImplementedException();
        }
    }
}
