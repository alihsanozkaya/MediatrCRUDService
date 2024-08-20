using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatrCRUDService.Application.Features.Products.Queries.GetByProductId
{
    public class GetByProductIdQueryRequest : IRequest<GetByProductIdQueryResponse>
    {
        public int Id { get; set; }
    }
}
