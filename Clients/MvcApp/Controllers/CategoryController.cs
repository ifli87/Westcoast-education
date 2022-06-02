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
    public class CategortController : Controller
    {
        private readonly ILogger<CategortController> _logger;

        public CategortController(ILogger<CategortController> logger)
        {
            _logger = logger;
        }

        public async Task <IActionResult> Index()
        {   
            var url = "https://localhost:7090/api/v1/category/courses";
            using var http = new HttpClient(url);
            var response = await http.GetAsync("");

            if (!respo)
            {
                
            }
            return View();
        }

    
    }
}