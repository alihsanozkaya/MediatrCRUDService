using MediatR;
using MediatrCRUDService.Application.Interfaces.AutoMapper;
using MediatrCRUDService.Application.Interfaces.UnitOfWorks;
using MediatrCRUDService.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatrCRUDService.Application.Features.Brands.Queries.GetAllBrands
{
    public class GetAllBrandsQueryHandler : IRequestHandler<GetAllBrandsQueryRequest, IList<GetAllBrandsQueryResponse>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public GetAllBrandsQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }
        public async Task<IList<GetAllBrandsQueryResponse>> Handle(GetAllBrandsQueryRequest request, CancellationToken cancellationToken)
        {
            var brands = await _unitOfWork.GetReadRepository<Brand>().GetAllAsync();
            var map = _mapper.Map<GetAllBrandsQueryResponse, Brand>(brands);

            return map;
        }
    }
}
