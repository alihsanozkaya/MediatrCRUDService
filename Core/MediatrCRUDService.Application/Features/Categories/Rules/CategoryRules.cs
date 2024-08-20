using MediatrCRUDService.Application.Bases;
using MediatrCRUDService.Application.Features.Categories.Exceptions;
using MediatrCRUDService.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatrCRUDService.Application.Features.Categories.Rules
{
    public class CategoryRules : BaseRules
    {
        public Task CategoryNameMustNotBeSame(IList<Category> categories, string requestName)
        {
            if (categories.Any(x => x.Name == requestName))
            {
                throw new CategoryNameMustNotBeSameException();
            }
            return Task.CompletedTask;
        }
    }
}
