using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.ComplexType;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete.Managers
{
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;

        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }


        [ValidationAspect(typeof(RentalValidator))]
        public IResult Add(Rental rental)
        {
            var carToRent = _rentalDal.Get(r => r.CarId == rental.CarId);
            if (carToRent != null || carToRent.ReturnDate > DateTime.Now)
            {
                return new ErrorResult(Messages.RentalInvalid);
            }
            _rentalDal.Add(rental);
            return new SuccessResult(Messages.RentalAdded);

        }

        public IDataResult<List<Rental>> GetAll()
        {
            if (_rentalDal.GetAll().Count <=0)
            {
                return new ErrorDataResult<List<Rental>>("Kiralık araç bulunamadı!");
            }
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll());
        }

        public IDataResult<Rental> GetById(int id)
        {
            return new SuccessDataResult<Rental>(_rentalDal.Get(r => r.Id == id));
        }

        public IDataResult<List<RentalDetail>> GetRentalDetail()
        {
            return new SuccessDataResult<List<RentalDetail>>(_rentalDal.GetRentalDetail());
        }
    }
}
