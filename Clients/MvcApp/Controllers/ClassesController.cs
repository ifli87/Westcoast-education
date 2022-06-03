using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using MvcApp.Models;
using MvcApp.ViewModels;

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

  
   [HttpGet()]
        public async Task <IActionResult> Details ()
        {
       try
       {
           var classesService = new ClassesServiceModel(_config);
           var classes = await classesService.ListAllClasses();
            return View(classes);
       }
       catch (System.Exception)
       {
           
           throw;
       }
        }
    
    }
}