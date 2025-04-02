using Application.Features.Products.Queries.GetAllProducts;
using Application.Interfaces.UnitOfWorks;
using Azure.Core;
using Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IMediator mediator;

        public ProductsController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> Get()
        {
            var response = await mediator.Send(new GetAllProductsQueryRequest());
            return Ok(response);
        }
    }
}
