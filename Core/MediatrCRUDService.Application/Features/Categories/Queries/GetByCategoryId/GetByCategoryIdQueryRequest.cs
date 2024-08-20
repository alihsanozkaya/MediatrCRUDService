using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatrCRUDService.Application.Features.Categories.Queries.GetByCategoryId
{
    public class GetByCategoryIdQueryRequest : IRequest<GetByCategoryIdQueryResponse>
    {
        public int Id { get; set; }
    }
}
