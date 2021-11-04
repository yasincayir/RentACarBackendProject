using Core.Utilities.Results;
using Entities.ComplexType;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IRentalService
    {
        IDataResult<List<Rental>> GetAll();
        IDataResult<Rental> GetById(int id);
        IResult Add(Rental rental);
        IDataResult<List<RentalDetail>> GetRentalDetail();
    }
}
