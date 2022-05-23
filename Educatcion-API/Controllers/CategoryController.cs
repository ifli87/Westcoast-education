using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Educatcion_API.Controllers
{
    [ApiController]
    [Route("api/v1/Category")]
    public class CategoryController : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult> ListAll ()
        {
            return Ok();
        }
        [HttpGet("{id}")]
        public async Task<ActionResult> ListById ()
        {
            return Ok();
        }
        [HttpPost]
        public async Task<ActionResult> CreateCategory ()
        {
            return StatusCode(201);
        }
        [HttpPut("{id}")]
        public async Task<ActionResult> UppdateCategory ()
        {
            return NoContent();
        }
        
    }
}