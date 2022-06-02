using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace MvcApp.Controllers
{
    [Route("[controller]")]
    public class ClassesController : Controller
    {
        private readonly ILogger<ClassesController> _logger;

        public classesController(ILogger<ClassesController> logger)
        {
            _logger = logger;
        }

        public async Task <IActionResult> Index()
        {   
            var options = new JsonSerializeOptions
            {
                PropertyNameCaseInsensitive = true
            };
            var url = "https://localhost:7090/api/v1/classes/courses";
            using var http = new HttpClient(url);
            var response = await http.GetAsync("");

            if (!response.ISsuccessStatusCode){
                console.writeline("ops");
            }
           var result = await response.Content.ReadAsStringAsync(options);
           var classes = JsonSerializer.Deserialize<List<ClassesViewModel>>(result);
            return View();
        }

    
    }
}