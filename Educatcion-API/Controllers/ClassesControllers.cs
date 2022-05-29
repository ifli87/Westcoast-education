
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
            await _classRepo.AddClassesAsync(model);
           if (await _classRepo.SaveAllAsync() )
           {
               
         return StatusCode(201, model);
           } 
           else
           {
               return StatusCode(500, "något gick fel");
           }
        }

        [HttpGet()]
        public async Task <ActionResult<List<ClassesViewModel>>> GetAllClasses()
        {
            
             return Ok (await _classRepo.ListAllClassesAsync());
        }

       

        [HttpPut("{id}")]
        public async Task <ActionResult> UpdateClasses(int id, PutClassesViewModel model)
        {
            try
            {
                await _classRepo.UppdateClassesAsync(id, model);

                if (await _classRepo.SaveAllAsync())
                {
                    return NoContent();
                }
                return StatusCode(500, "Ett fel inträffade när kursen skulle uppdateras");
            }

            catch (Exception ex)
            {
                return StatusCode (500, ex.Message);
            }
        }


        [HttpGet("{id}")]
        public async Task <ActionResult> GetClassById(int id)
        {
            var response = await _classRepo.GetClassesAsync(id);
            if (response is null)
            {
                return NotFound($"Det finns ingen kurs med id: {id} ");
            }
            return Ok(response);
        }

        // [HttpGet("{id}")]
        // public async Task <ActionResult> GetClassesByCategoryAsync([FromQuery] string category)
        // {
        //    return Ok(await _classRepo.GetClassesByCategoryAsync(category));
        // }

    }
}