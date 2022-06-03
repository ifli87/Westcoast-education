using Microsoft.AspNetCore.Mvc;
using MvcApp.Models;

namespace MvcApp.Controllers
{
    [Route("[controller]")]
    public class ClassesController : Controller
    {
        private readonly IConfiguration _config;
        public ClassesController(IConfiguration config)
        {
            _config = config;
        }

  
        [HttpGet("")]
        public async Task <IActionResult> Details ()
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