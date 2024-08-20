using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatrCRUDService.Application.Features.Brands.Command.DeleteBrand
{
    public class DeleteBrandCommandValidator : AbstractValidator<DeleteBrandCommandRequest>
    {
        public DeleteBrandCommandValidator()
        {
            RuleFor(x => x.Id).GreaterThan(0);
        }
    }
}
