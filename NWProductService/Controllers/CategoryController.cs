using Microsoft.AspNetCore.Mvc;
using System.Collections;

namespace NWProductService.Controllers
{
    [ApiController]
    [Route("api/satis/[controller]/[action]")]
    public class ProductController : ControllerBase
    {
        [HttpGet(Name = "GetCategories")]
        public IEnumerable GetCat()
        {
            Models.NortwindContext cnt = new Models.NortwindContext();
            return cnt.Categories.Select(x => new { x.CategoryId, name = x.CategoryName });
        }
        [HttpGet("{categoryId}")]
        public IEnumerable GetByCategoryId(int categoryId)
        {
            Models.NortwindContext cnt = new Models.NortwindContext();
            return cnt.Products.Where(x => x.CategoryId == categoryId);
        }
    }
}
