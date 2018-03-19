using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DataAccess.Services;
using System.Threading.Tasks;

namespace GOAPI.Controllers
{
    public class CategoryController : ApiController
    {
        ICategoryService _categoryService;
        public CategoryController()
        {
        }
        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }


        // GET: /api/Categories
        [Authorize]
        [HttpGet]
        [Route("api/Categories")]
        public IHttpActionResult GetAllCategories()
        {
            var resultData = _categoryService.GetAll();
            if (resultData == null)
            {
                return NotFound();
            }
            return Ok(resultData);
        }
    }
}
