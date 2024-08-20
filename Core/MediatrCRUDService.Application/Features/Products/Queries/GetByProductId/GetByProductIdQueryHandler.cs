using MediatR;
using MediatrCRUDService.Application.DTOs;
using MediatrCRUDService.Application.Interfaces.AutoMapper;
using MediatrCRUDService.Application.Interfaces.UnitOfWorks;
using MediatrCRUDService.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatrCRUDService.Application.Features.Products.Queries.GetByProductId
{
    public class GetByProductIdQueryHandler : IRequestHandler<GetByProductIdQueryRequest, GetByProductIdQueryResponse>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetByProductIdQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<GetByProductIdQueryResponse> Handle(GetByProductIdQueryRequest request, CancellationToken cancellationToken)
        {
            var product = await _unitOfWork.GetReadRepository<Product>().GetAsync(x => x.Id == request.Id, include: x => x.Include(b => b.Brand));
            _mapper.Map<BrandDto, Brand>(new Brand());
            var response = _mapper.Map<GetByProductIdQueryResponse, Product>(product);

            return response;
        }
    }
}
