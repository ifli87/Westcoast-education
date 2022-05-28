
using Educatcion_API.Interfaces;
using Educatcion_API.Models;
using Educatcion_API.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Educatcion_API.Controllers
{
    [ApiController]
    [Route("api/v1/classes")]
    public class ClassesController : ControllerBase
    {
        private readonly IClassesRepository _classRepo;

        
        public ClassesController (IClassesRepository classRepo)
        {
            _classRepo = classRepo;
        }

        [HttpPost()]
        public async Task <ActionResult> AddClassAsync(PostClassesViewModel model)
        {
            
         return StatusCode(201, model);
        }

        [HttpGet()]
        public async Task <ActionResult<List<ClassesViewModel>>> GetAllClasses()
        {
            
             return Ok (await _classRepo.ListAllClassesAsync());
        }
        [HttpGet("{id}")]
        public async Task <ActionResult> GetClassById(Classes classes)
        {
            return Ok();
        }

        [HttpDelete()]
        public async Task <ActionResult> DeleteClass(Classes classes)
        {
            return Ok();
        }

        [HttpPut()]
        public async Task <ActionResult> UpdateClasses(Classes classes)
        {
            return NoContent();
        }



    }
}