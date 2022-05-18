
using Educatcion_API.Models;
using Microsoft.AspNetCore.Mvc;

namespace Educatcion_API.Controllers
{
    [ApiController]
    [Route("api/v1/")]
    public class EducationControllers : ControllerBase
    {

        [HttpPost()]
        public ActionResult AddClass(Classes classes)
        {
            return Ok();
        }

        [HttpGet()]
        public ActionResult GetAllClasses(Classes classes)
        {
            return Ok();
        }
        [HttpGet("{id}")]
        public ActionResult GetClassById(Classes classes)
        {
            return Ok();
        }

        [HttpDelete()]
        public ActionResult DeleteClass(Classes classes)
        {
            return Ok();
        }

        [HttpPut()]
        public ActionResult UpdateClasses(Classes classes)
        {
            return Ok();
        }



    }
}