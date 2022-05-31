using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Educatcion_API.Interfaces;
using Educatcion_API.ViewModels.Teacher;
using Microsoft.AspNetCore.Mvc;

namespace Educatcion_API.Controllers
{
    [ApiController]
    [Route("api/v1/teacher")]
    public class TeacherController : ControllerBase
    {
        private readonly ITeacherRepository _teacherrepo;
        public TeacherController(ITeacherRepository teacherrepo)
        {
            _teacherrepo = teacherrepo;
        }

        [HttpPost()]
        public async Task <ActionResult> AddTeacher (PostTeacherViewModel model)
        {
           
             await _teacherrepo.AddTeacherAsync(model);
            if (await _teacherrepo.SaveAllAsync())
            {   
            return StatusCode(201);
            }
            return StatusCode (500, " ops något gick fel vid sparande av studenten");
        }
        [HttpGet()]
        public async Task <ActionResult> ListAllTeacher ()
        {
             return Ok (await _teacherrepo.ListAllTeachersAsync());
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