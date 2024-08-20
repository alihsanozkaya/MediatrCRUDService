using FluentValidation;
using MediatrCRUDService.Application.Features.Products.Command.CreateProduct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatrCRUDService.Application.Features.Brands.Command.CreateBrand
{
    public class CreateBrandCommandValidator : AbstractValidator<CreateBrandCommandRequest>
    {
        public CreateBrandCommandValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithName("Marka adı");
        }
    }
}
