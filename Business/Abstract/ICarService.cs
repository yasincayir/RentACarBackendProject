using Core.Utilities.Results;
using Entities.ComplexType;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        IDataResult< List<Car>> GetAll();
        IDataResult< Car> GetById(int id);
        IResult Add(Car car);
        IDataResult< List<Car>> GetCarsByBrandId(int id);
        IDataResult< List<Car>> GetCarsByColorId(int id);
        IDataResult< List<CarDetail>> GetCarDetails();
        IResult AddTransactionalTest(Car car);

    }
}
