using MediatR;
using MediatrCRUDService.Application.Features.Brands.Rules;
using MediatrCRUDService.Application.Interfaces.UnitOfWorks;
using MediatrCRUDService.Domain.Entities;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace MediatrCRUDService.Application.Features.Brands.Command.UpdateBrand
{
    public class UpdateBrandCommandHandler : IRequestHandler<UpdateBrandCommandRequest, Unit>
    {
        private readonly IUnitOfWork _unitOfWork;
        public UpdateBrandCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Unit> Handle(UpdateBrandCommandRequest request, CancellationToken cancellationToken)
        {
            var brand = await _unitOfWork.GetReadRepository<Brand>().GetAsync(x => x.Id == request.Id);

            if (brand == null)
            {
                throw new Exception("Marka bulunamadı.");
            }

            brand.Name = request.Name;

            await _unitOfWork.GetWriteRepository<Brand>().UpdateAsync(brand);
            await _unitOfWork.SaveAsync();

            return Unit.Value;
        }
    }
}
