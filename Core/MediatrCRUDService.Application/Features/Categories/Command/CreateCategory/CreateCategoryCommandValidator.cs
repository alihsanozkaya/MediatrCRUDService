using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatrCRUDService.Application.Features.Categories.Command.CreateCategory
{
    public class CreateCategoryCommandValidator : AbstractValidator<CreateCategoryCommandRequest>
    {
        public CreateCategoryCommandValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithName("Kategori adı");
        }
    }
}
