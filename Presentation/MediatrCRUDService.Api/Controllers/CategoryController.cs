using MediatR;
using MediatrCRUDService.Application.Features.Categories.Command.CreateCategory;
using MediatrCRUDService.Application.Features.Categories.Command.DeleteCategory;
using MediatrCRUDService.Application.Features.Categories.Command.UpdateCategory;
using MediatrCRUDService.Application.Features.Categories.Queries.GetAllCategories;
using MediatrCRUDService.Application.Features.Categories.Queries.GetByCategoryId;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MediatrCRUDService.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly IMediator _mediator;
        public CategoryController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllCategories()
        {
            var response = await _mediator.Send(new GetAllCategoriesQueryRequest());
            return Ok(response);
        }

        [HttpGet]
        public async Task<IActionResult> GetByCategoryId(int id)
        {
            var response = await _mediator.Send(new GetByCategoryIdQueryRequest { Id = id });
            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> CreateCategory(CreateCategoryCommandRequest request)
        {
            await _mediator.Send(request);
            return Ok(request);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateCategory(UpdateCategoryCommandRequest request)
        {
            await _mediator.Send(request);
            return Ok(request);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteCategory(DeleteCategoryCommandRequest request)
        {
            await _mediator.Send(request);
            return Ok();
        }
    }
}
