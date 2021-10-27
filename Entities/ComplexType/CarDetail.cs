using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.ComplexType
{
    public class CarDetail: IComplexType
    {
        public string CarName { get; set; }
        public string BrandName { get; set; }
        public string ColorName { get; set; }
        public Decimal DailyPrice { get; set; }
    }
}
