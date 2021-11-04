using Core.DataAccess;
using Core.Utilities.Results;
using Entities.ComplexType;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface ICarDal:IEntityRepository<Car>
    {
       List<CarDetail> GetCarDetail();
    }
}
