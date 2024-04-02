using MultiShop.Cargo.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiShop.DataAccessLayer.Abstract
{
    public interface ICargoDetailDal : IGenericDal<CargoDetail>
    {
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<CargoDetail> GetAll()
        {
            throw new NotImplementedException();
        }

        public CargoDetail GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(CargoDetail entity)
        {
            throw new NotImplementedException();
        }

        public void Update(CargoDetail entity)
        {
            throw new NotImplementedException();
        }
    }
}
