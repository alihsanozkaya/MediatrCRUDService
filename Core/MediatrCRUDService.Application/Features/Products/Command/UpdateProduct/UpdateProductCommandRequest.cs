using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatrCRUDService.Application.Features.Products.Command.UpdateProduct
{
    public class UpdateProductCommandRequest : IRequest<Unit>
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int BrandId { get; set; }
        public IList<int> CategoryIds { get; set; }
    }
}
