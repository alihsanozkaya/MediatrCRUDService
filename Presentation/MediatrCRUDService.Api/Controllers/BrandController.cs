using MediatR;
using MediatrCRUDService.Application.Features.Brands.Command.CreateBrand;
using MediatrCRUDService.Application.Features.Brands.Command.DeleteBrand;
using MediatrCRUDService.Application.Features.Brands.Command.UpdateBrand;
using MediatrCRUDService.Application.Features.Brands.Queries.GetAllBrands;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MediatrCRUDService.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class BrandController : ControllerBase
    {
        private readonly IMediator _mediator;
        public BrandController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllBrands()
        {
            var response = await _mediator.Send(new GetAllBrandsQueryRequest());
            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> CreateBrand(CreateBrandCommandRequest request)
        {
            await _mediator.Send(request);
            return Ok(request);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateBrand(UpdateBrandCommandRequest request)
        {
            await _mediator.Send(request);
            return Ok(request);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteBrand(DeleteBrandCommandRequest request)
        {
            await _mediator.Send(request);
            return Ok();
        }
    }
}
