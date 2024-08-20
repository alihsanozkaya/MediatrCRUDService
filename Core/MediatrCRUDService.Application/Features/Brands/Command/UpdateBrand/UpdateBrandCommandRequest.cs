﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatrCRUDService.Application.Features.Brands.Command.UpdateBrand
{
    public class UpdateBrandCommandRequest : IRequest<Unit>
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
