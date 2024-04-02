using MultiShop.Cargo.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiShop.DataAccessLayer.Abstract
{
    public interface ICargoOperationDal : IGenericDal<CargoOperation>
    {
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<CargoOperation> GetAll()
        {
            throw new NotImplementedException();
        }

        public CargoOperation GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(CargoOperation entity)
        {
            throw new NotImplementedException();
        }

        public void Update(CargoOperation entity)
        {
            throw new NotImplementedException();
        }
    }
}
