using Educatcion_API.Interfaces;
using Educatcion_API.ViewModels.Categorys;
using Microsoft.AspNetCore.Mvc;

namespace Educatcion_API.Controllers
{
    [ApiController]
    [Route("api/v1/category")]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryRepository _categoryRepo;
        public CategoryController(ICategoryRepository categoryRepo )
        {
            _categoryRepo = categoryRepo;

        }

        [HttpGet]
        public async Task<ActionResult> ListAll ()
        {
            var list = await _categoryRepo.ListCategoryAsync();
            return Ok(list);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult> ListById (int id)
        {
            return Ok(await _categoryRepo.GetCategoryById(id));
        }
        [HttpPost]
        public async Task<ActionResult> AddCategory (PostCategoryViewModel model)
        {
            await _categoryRepo.AddCategoryAsync(model);
            if (await _categoryRepo.SaveAllAsync())
            {   
            return StatusCode(201);
            }
            return StatusCode (500, " ops något gick fel vid sparande av category");
        }
       
        [HttpGet("courses")]
        public async Task<ActionResult> ListCategorysWithClasses ()
        {
          return Ok (await _categoryRepo.ListCategorysClasses());
        }
    }
}