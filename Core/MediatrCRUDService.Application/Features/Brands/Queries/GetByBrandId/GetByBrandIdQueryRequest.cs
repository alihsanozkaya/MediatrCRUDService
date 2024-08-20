using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatrCRUDService.Application.Features.Brands.Queries.GetByBrandId
{
    public class GetByBrandIdQueryRequest : IRequest<GetByBrandIdQueryResponse>
    {
        public int Id { get; set; }
    }
}
