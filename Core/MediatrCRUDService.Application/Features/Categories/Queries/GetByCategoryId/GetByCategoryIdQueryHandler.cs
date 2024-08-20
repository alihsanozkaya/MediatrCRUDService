using MediatR;
using MediatrCRUDService.Application.Interfaces.AutoMapper;
using MediatrCRUDService.Application.Interfaces.UnitOfWorks;
using MediatrCRUDService.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatrCRUDService.Application.Features.Categories.Queries.GetByCategoryId
{
    public class GetByCategoryIdQueryHandler : IRequestHandler<GetByCategoryIdQueryRequest, GetByCategoryIdQueryResponse>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetByCategoryIdQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<GetByCategoryIdQueryResponse> Handle(GetByCategoryIdQueryRequest request, CancellationToken cancellationToken)
        {
            var category = await _unitOfWork.GetReadRepository<Category>().GetAsync(x => x.Id == request.Id);
            var response = _mapper.Map<GetByCategoryIdQueryResponse, Category>(category);

            return response;
        }
    }
}
