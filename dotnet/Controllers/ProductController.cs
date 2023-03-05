using dotnet.Data;
using Microsoft.AspNetCore.Mvc;

namespace dotnet.Controllers
{
    [Route("api")]
    [ApiController]
    public class ProductController : Controller
    {
        private readonly ProductRepository _repository;
        public ProductController(ProductRepository repository)
        {
            _repository = repository;
        }
        [HttpGet("products/all")]
        public IActionResult all(
            [FromQuery(Name = "s")] string s,
            [FromQuery(Name = "sort")] string sort,
            [FromQuery(Name = "page")] int page
        )
        {
            return Ok(_repository.Query(s, sort, page));
        }
        [HttpGet("products/get/{memberId}")]
        public IActionResult get(int memberId)
        {
            return Ok(_repository.Get().FirstOrDefault(x=>x.memberId==memberId));
        }
        
    }
}