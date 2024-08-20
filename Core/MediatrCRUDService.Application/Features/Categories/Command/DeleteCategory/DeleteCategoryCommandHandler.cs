using MediatR;
using MediatrCRUDService.Application.Interfaces.UnitOfWorks;
using MediatrCRUDService.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatrCRUDService.Application.Features.Categories.Command.DeleteCategory
{
    public class DeleteCategoryCommandHandler : IRequestHandler<DeleteCategoryCommandRequest, Unit>
    {
        private readonly IUnitOfWork _unitOfWork;
        public DeleteCategoryCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Unit> Handle(DeleteCategoryCommandRequest request, CancellationToken cancellationToken)
        {
            var category = await _unitOfWork.GetReadRepository<Category>().GetAsync(x => x.Id == request.Id);

            if (category == null)
            {
                throw new Exception("Kategori bulunamadı.");
            }

            await _unitOfWork.GetWriteRepository<Category>().DeleteAsync(category);
            await _unitOfWork.SaveAsync();

            return Unit.Value;
        }
    }
}
