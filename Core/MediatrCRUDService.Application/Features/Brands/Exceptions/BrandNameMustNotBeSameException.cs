using MediatrCRUDService.Application.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatrCRUDService.Application.Features.Brands.Exceptions
{
    public class BrandNameMustNotBeSameException : BaseExceptions
    {
        public BrandNameMustNotBeSameException() : base("Marka adı mevcut!")
        {
            
        }
    }
}
