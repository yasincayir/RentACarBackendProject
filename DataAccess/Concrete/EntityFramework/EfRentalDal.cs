using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.ComplexType;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, CarContext>, IRentalDal
    {
        public List<RentalDetail> GetRentalDetail()
        {
            using (CarContext context=new CarContext())
            {
                var result = from c in context.Cars
                             join r in context.Rentals
                             on c.Id equals r.CarId
                             join b in context.Brands
                             on c.BrandId equals b.Id
                             join cs in context.Customers
                             on r.CustomerId equals cs.Id
                             join us in context.Users
                             on cs.UserId equals us.Id
                             select new RentalDetail
                             {
                                 BrandName=b.Name,
                                 Name=us.FirstName +" "+ us.LastName,
                             };
                return result.ToList();
                             
                             
                           
            }
        }
    }
}
