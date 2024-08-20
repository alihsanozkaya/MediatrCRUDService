using MediatR;
using MediatrCRUDService.Application.Features.Categories.Rules;
using MediatrCRUDService.Application.Interfaces.UnitOfWorks;
using MediatrCRUDService.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatrCRUDService.Application.Features.Categories.Command.CreateCategory
{
    public class CreateCategoryCommandHandler : IRequestHandler<CreateCategoryCommandRequest, Unit>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly CategoryRules _categoryRules;
        public CreateCategoryCommandHandler(IUnitOfWork unitOfWork, CategoryRules categoryRules)
        {
            _categoryRules = categoryRules;
            _unitOfWork = unitOfWork;
        }
        public async Task<Unit> Handle(CreateCategoryCommandRequest request, CancellationToken cancellationToken)
        {
            IList<Category> categories = await _unitOfWork.GetReadRepository<Category>().GetAllAsync();

            await _categoryRules.CategoryNameMustNotBeSame(categories, request.Name);

            Category category = new Category(request.Name);
            await _unitOfWork.GetWriteRepository<Category>().AddAsync(category);

            if (await _unitOfWork.SaveAsync() > 0)
            {
                await _unitOfWork.SaveAsync();
            }
            return Unit.Value;
        }
    }
}
