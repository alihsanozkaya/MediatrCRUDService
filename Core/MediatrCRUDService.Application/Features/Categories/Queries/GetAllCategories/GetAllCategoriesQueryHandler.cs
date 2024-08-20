using MediatR;
using MediatrCRUDService.Application.Interfaces.AutoMapper;
using MediatrCRUDService.Application.Interfaces.UnitOfWorks;
using MediatrCRUDService.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatrCRUDService.Application.Features.Categories.Queries.GetAllCategories
{
    public class GetAllCategoriesQueryHandler : IRequestHandler<GetAllCategoriesQueryRequest, IList<GetAllCategoriesQueryResponse>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public GetAllCategoriesQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }
        public async Task<IList<GetAllCategoriesQueryResponse>> Handle(GetAllCategoriesQueryRequest request, CancellationToken cancellationToken)
        {
            var categories = await _unitOfWork.GetReadRepository<Category>().GetAllAsync();
            var map = _mapper.Map<GetAllCategoriesQueryResponse, Category>(categories);

            return map;
        }
    }
}
