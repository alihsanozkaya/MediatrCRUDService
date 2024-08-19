using MediatR;
using MediatrCRUDService.Application.Features.Products.Rules;
using MediatrCRUDService.Application.Interfaces.UnitOfWorks;
using MediatrCRUDService.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatrCRUDService.Application.Features.Products.Command.CreateProduct
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommandRequest, Unit>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ProductRules _productRules;
        public CreateProductCommandHandler(IUnitOfWork unitOfWork, ProductRules productRules)
        {
            _productRules = productRules;
            _unitOfWork = unitOfWork;
        }
        public async Task<Unit> Handle(CreateProductCommandRequest request, CancellationToken cancellationToken)
        {
            IList<Product> products = await _unitOfWork.GetReadRepository<Product>().GetAllAsync();

            await _productRules.ProductTitleMustNotBeSame(products, request.Title);

            Product product = new Product(request.Title, request.Description, request.BrandId, request.Price);
            await _unitOfWork.GetWriteRepository<Product>().AddAsync(product);

            if (await _unitOfWork.SaveAsync() > 0)
            {
                foreach (var categoryId in request.CategoryIds)
                {
                    await _unitOfWork.GetWriteRepository<ProductCategory>().AddAsync(new()
                    {
                        CategoryId = categoryId,
                        ProductId = product.Id,
                    });
                }
                await _unitOfWork.SaveAsync();
            }
            return Unit.Value;
        }
    }
}
