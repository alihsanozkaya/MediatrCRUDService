using MediatR;
using MediatrCRUDService.Application.Features.Brands.Rules;
using MediatrCRUDService.Application.Interfaces.UnitOfWorks;
using MediatrCRUDService.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatrCRUDService.Application.Features.Brands.Command.CreateBrand
{
    public class CreateBrandCommandHandler : IRequestHandler<CreateBrandCommandRequest, Unit>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly BrandRules _brandRules;
        public CreateBrandCommandHandler(IUnitOfWork unitOfWork, BrandRules brandRules)
        {
            _unitOfWork = unitOfWork;
            _brandRules = brandRules;
        }
        public async Task<Unit> Handle(CreateBrandCommandRequest request, CancellationToken cancellationToken)
        {
            IList<Brand> brands = await _unitOfWork.GetReadRepository<Brand>().GetAllAsync();

            await _brandRules.BrandNameMustNotBeSame(brands, request.Name);

            Brand brand = new Brand(request.Name);
            await _unitOfWork.GetWriteRepository<Brand>().AddAsync(brand);

            if (await _unitOfWork.SaveAsync() > 0)
            {
                await _unitOfWork.SaveAsync();
            }
            return Unit.Value;
        }
    }
}
