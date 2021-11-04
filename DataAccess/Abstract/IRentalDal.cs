﻿using Core.DataAccess;
using Entities.ComplexType;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IRentalDal:IEntityRepository<Rental>
    {
        List<RentalDetail> GetRentalDetail();
    }
}
