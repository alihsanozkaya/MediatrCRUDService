using MediatR;
using MediatrCRUDService.Application.Interfaces.AutoMapper;
using MediatrCRUDService.Application.Interfaces.UnitOfWorks;
using MediatrCRUDService.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatrCRUDService.Application.Features.Brands.Queries.GetByBrandId
{
    public class GetByBrandIdQueryHandler : IRequestHandler<GetByBrandIdQueryRequest, GetByBrandIdQueryResponse>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetByBrandIdQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<GetByBrandIdQueryResponse> Handle(GetByBrandIdQueryRequest request, CancellationToken cancellationToken)
        {
            var brand = await _unitOfWork.GetReadRepository<Brand>().GetAsync(x => x.Id == request.Id);
            var response = _mapper.Map<GetByBrandIdQueryResponse, Brand>(brand);

            return response;
        }
    }
}
