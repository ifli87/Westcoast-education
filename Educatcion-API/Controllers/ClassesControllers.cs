
using Educatcion_API.Interfaces;
using Educatcion_API.Models;
using Educatcion_API.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Educatcion_API.Controllers
{
    [ApiController]
    [Route("api/v1/")]
    public class ClassesController : ControllerBase
    {
        private readonly IClassesRepository _classRepo;
        
        public ClassesController (IClassesRepository classRepo)
        {
            _classRepo = classRepo;
        }

        [HttpPost()]
        public async Task <ActionResult> AddClass(ClassesViewModel model)
        {
           try
           {
               if (await _classRepo.GetClassesByCategoryAsync(model.))
               {
                   
               }
            await _classRepo.AddClassesAsync(model);
            if (await _classRepo.SaveAllAsync())
            {   
                return StatusCode(201);
            }
            return StatusCode(500, "Det gick inte att spara kursen"):
           }
           catch (System.Exception)
           {
               
               throw;
           }
        }

        [HttpGet()]
        public async Task <ActionResult> GetAllClasses(Classes classes)
        {
            return Ok();
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