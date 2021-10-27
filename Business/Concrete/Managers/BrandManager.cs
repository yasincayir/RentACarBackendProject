using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete.Managers
{
    public class BrandManager : IBrandService
    {
        
        IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        [ValidationAspect(typeof(BrandValidator))]
        public IResult Add(Brand brand)
        {
            _brandDal.Add(brand);
            return new SuccessResult(Messages.BrandAdded);
        }


        public IResult Delete(Brand brand)
        {
            
            _brandDal.Delete(brand);
            return new SuccessResult();
        }


        public IDataResult<List<Brand>> GetAll()
        {
            var result = _brandDal.GetAll();
            if (result==null)
            {
                return new ErrorDataResult<List<Brand>>();
            }
            return new SuccessDataResult<List<Brand>>(result, Messages.BrandListed);
        }

        public IDataResult<Brand> GetById(int id)
        {
            var result = _brandDal.Get(b => b.Id == id);
            if (result==null)
            {
                return new ErrorDataResult<Brand>("Marka Bulunamadı!");
            }
            return new SuccessDataResult<Brand>(result);
        }
    }
}
