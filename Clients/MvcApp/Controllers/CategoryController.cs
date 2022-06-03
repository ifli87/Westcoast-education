using Microsoft.AspNetCore.Mvc;
using MvcApp.Models;

namespace MvcApp.Controllers
{
    [Route("[controller]")]
    public class CategoryController : Controller
    {
        private readonly IConfiguration _config;
        public CategoryController(IConfiguration config)
        {
            _config = config;
        }

        [HttpGet("")]
        public async Task <IActionResult> Index ()
        {
       try
       {
           var classesServiceWithCategory = new ClassesServiceModel(_config);
           var category = await classesServiceWithCategory.ListAllClassesWithCategory();
            return View(category);
       }
       catch (System.Exception)
       {
           
           throw;
       }
        }

       

    }
}