using MediatR;
using MediatrCRUDService.Application.Features.Products.Command.CreateProduct;
using MediatrCRUDService.Application.Features.Products.Command.DeleteProduct;
using MediatrCRUDService.Application.Features.Products.Command.UpdateProduct;
using MediatrCRUDService.Application.Features.Products.Queries.GetAllProducts;
using MediatrCRUDService.Application.Features.Products.Queries.GetByProductId;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MediatrCRUDService.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IMediator _mediator;
        public ProductController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllProducts()
        {
            var response = await _mediator.Send(new GetAllProductsQueryRequest());
            return Ok(response);
        }

        [HttpGet]
        public async Task<IActionResult> GetByProductId(int id)
        {
            var response = await _mediator.Send(new GetByProductIdQueryRequest { Id = id });
            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> CreateProduct(CreateProductCommandRequest request)
        {
            await _mediator.Send(request);
            return Ok(request);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateProduct(UpdateProductCommandRequest request)
        {
            await _mediator.Send(request);
            return Ok(request);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteProduct(DeleteProductCommandRequest request)
        {
            await _mediator.Send(request);
            return Ok();
        }
    }
}
