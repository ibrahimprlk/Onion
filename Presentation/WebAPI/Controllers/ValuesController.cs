using Application.Interfaces.UnitOfWorks;
using Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public ValuesController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> Get()
        {
            var t = await _unitOfWork.GetReadRepository<Product>().GetAllAsync();
            return Ok(t);
        }
    }
}
