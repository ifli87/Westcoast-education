using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Educatcion_API.Controllers
{
    [ApiController]
    [Route("api/v1/teacher")]
    public class TeacherController : ControllerBase
    {
          [HttpPost()]
        public async Task <ActionResult> AddTeacher ()
        {
            return Ok();
        }
        [HttpGet()]
        public async Task <ActionResult> ListAllTeacher ()
        {
            return Ok();
        }
        [HttpPut()]
        public async Task <ActionResult> UppdateTeacher ()
        {
            return Ok();
        }
        [HttpGet("{id}")]
        public async Task <ActionResult> GetTeacherById (int id)
        {
            return Ok();
        }
       
    }
}