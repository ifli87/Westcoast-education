using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Educatcion_API.Interfaces;
using Educatcion_API.ViewModels.Student;
using Microsoft.AspNetCore.Mvc;

namespace Educatcion_API.Controllers
{
    [ApiController]
    [Route("api/v1/student")]
    public class StudentController  : ControllerBase
    {
        private readonly IStudentRepository _studentRepo;
        public StudentController(IStudentRepository studentRepo)
        {
            _studentRepo = studentRepo;
        }

        [HttpPost()]
        public async Task <ActionResult> AddStudent (PostStudentViewModel model)
        {
             await _studentRepo.AddStudentAsync(model);
            if (await _studentRepo.SaveAllAsync())
            {   
            return StatusCode(201);
            }
            return StatusCode (500, " ops något gick fel vid sparande av studenten");
        }
        [HttpGet()]
        public async Task <ActionResult> ListAllStudents ()
        {
           return Ok (await _studentRepo.ListAllStudentsAsync());
        }
        [HttpPut()]
        public async Task <ActionResult> UppdateStudent (int id, PutStudentViewModel model)
        {
          try
            {
                await _studentRepo.UppdateStudentAsync(id, model);

                if (await _studentRepo.SaveAllAsync())
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
        public async Task <ActionResult> GetStudentById (int id)
        {
            var response = await _studentRepo.GetStudentById(id);
            if (response is null)
            {
                return NotFound($"Det finns ingen Student med id: {id} ");
            }
            return Ok(response);
        }
       
    }
}