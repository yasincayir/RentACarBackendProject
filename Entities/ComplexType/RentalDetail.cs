using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.ComplexType
{
    public class RentalDetail:IComplexType
    {
        public string BrandName { get; set; }
        public string Name { get; set; }
    }
}
