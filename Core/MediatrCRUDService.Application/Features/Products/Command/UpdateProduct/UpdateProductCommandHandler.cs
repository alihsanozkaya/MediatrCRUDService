using MediatR;
using MediatrCRUDService.Application.Interfaces.AutoMapper;
using MediatrCRUDService.Application.Interfaces.UnitOfWorks;
using MediatrCRUDService.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatrCRUDService.Application.Features.Products.Command.UpdateProduct
{
    public class UpdateProductCommandHandler : IRequestHandler<UpdateProductCommandRequest, Unit>
    {
        private readonly IUnitOfWork _unitOfWork;
        public UpdateProductCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<Unit> Handle(UpdateProductCommandRequest request, CancellationToken cancellationToken)
        {
            var product = await _unitOfWork.GetReadRepository<Product>().GetAsync(x => x.Id == request.Id);
            
            if (product == null)
            {
                throw new Exception("Ürün bulunamadı.");
            }

            var productCategories = await _unitOfWork.GetReadRepository<ProductCategory>()
                .GetAllAsync(x => x.ProductId == product.Id);

            await _unitOfWork.GetWriteRepository<ProductCategory>().DeleteRangeAsync(productCategories);

            foreach (var categoryId in request.CategoryIds)
            {
                await _unitOfWork.GetWriteRepository<ProductCategory>()
                    .AddAsync(new() { CategoryId = categoryId, ProductId = product.Id });
            }
            product.Title = request.Title;
            product.Description = request.Description;
            product.Price = request.Price;
            product.BrandId = request.BrandId;
            await _unitOfWork.GetWriteRepository<Product>().UpdateAsync(product);
            await _unitOfWork.SaveAsync();

            return Unit.Value;
        }
    }
}
