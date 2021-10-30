using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.ComplexType
{
    public class UserForLoginDto : IComplexType
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
