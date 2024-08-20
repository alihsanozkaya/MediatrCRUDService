using MediatR;
using MediatrCRUDService.Application.Features.Categories.Rules;
using MediatrCRUDService.Application.Interfaces.UnitOfWorks;
using MediatrCRUDService.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatrCRUDService.Application.Features.Categories.Command.UpdateCategory
{
    public class UpdateCategoryCommandHandler : IRequestHandler<UpdateCategoryCommandRequest, Unit>
    {
        private readonly IUnitOfWork _unitOfWork;

        public UpdateCategoryCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Unit> Handle(UpdateCategoryCommandRequest request, CancellationToken cancellationToken)
        {
            var category = await _unitOfWork.GetReadRepository<Category>().GetAsync(x => x.Id == request.Id);

            if (category == null)
            {
                throw new Exception("Kategori bulunamadı.");
            }

            category.Name = request.Name;

            await _unitOfWork.GetWriteRepository<Category>().UpdateAsync(category);
            await _unitOfWork.SaveAsync();

            return Unit.Value;
        }
    }
}
