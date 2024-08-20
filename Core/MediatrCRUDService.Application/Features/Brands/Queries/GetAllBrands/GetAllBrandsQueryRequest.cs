﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatrCRUDService.Application.Features.Brands.Queries.GetAllBrands
{
    public class GetAllBrandsQueryRequest : IRequest<IList<GetAllBrandsQueryResponse>>
    {
    }
}
