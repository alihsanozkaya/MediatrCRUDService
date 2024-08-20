using MediatrCRUDService.Application.Bases;
using MediatrCRUDService.Application.Features.Brands.Exceptions;
using MediatrCRUDService.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatrCRUDService.Application.Features.Brands.Rules
{
    public class BrandRules : BaseRules
    {
        public Task BrandNameMustNotBeSame(IList<Brand> brands, string requestName)
        {
            if (brands.Any(x => x.Name == requestName))
            {
                throw new BrandNameMustNotBeSameException();
            }
            return Task.CompletedTask;
        }
    }
}
