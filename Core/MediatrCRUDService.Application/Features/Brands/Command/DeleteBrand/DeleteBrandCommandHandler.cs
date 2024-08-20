using MediatR;
using MediatrCRUDService.Application.Interfaces.UnitOfWorks;
using MediatrCRUDService.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatrCRUDService.Application.Features.Brands.Command.DeleteBrand
{
    public class DeleteBrandCommandHandler : IRequestHandler<DeleteBrandCommandRequest, Unit>
    {
        private readonly IUnitOfWork _unitOfWork;
        public DeleteBrandCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Unit> Handle(DeleteBrandCommandRequest request, CancellationToken cancellationToken)
        {
            var brand = await _unitOfWork.GetReadRepository<Brand>().GetAsync(x => x.Id == request.Id);

            if (brand == null)
            {
                throw new Exception("Marka bulunamadı.");
            }

            await _unitOfWork.GetWriteRepository<Brand>().DeleteAsync(brand);
            await _unitOfWork.SaveAsync();

            return Unit.Value;
        }
    }
}
