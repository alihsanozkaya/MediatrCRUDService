using MediatR;
using MediatrCRUDService.Application.Interfaces.UnitOfWorks;
using MediatrCRUDService.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatrCRUDService.Application.Features.Products.Command.DeleteProduct
{
    public class DeleteProductCommandHandler : IRequestHandler<DeleteProductCommandRequest, Unit>
    {
        private readonly IUnitOfWork _unitOfWork;
        public DeleteProductCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Unit> Handle(DeleteProductCommandRequest request, CancellationToken cancellationToken)
        {
            var product = await _unitOfWork.GetReadRepository<Product>().GetAsync(x => x.Id == request.Id);

            if (product == null)
            {
                throw new Exception("Ürün bulunamadı.");
            }
            await _unitOfWork.GetWriteRepository<Product>().DeleteAsync(product);
            await _unitOfWork.SaveAsync();

            return Unit.Value;
        }
    }
}
