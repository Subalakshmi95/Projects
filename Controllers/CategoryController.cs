using Microsoft.AspNetCore.Mvc;
using StoreApi.Models;
using StoreApi.Services;

namespace StoreApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CategoryController : Controller
    {
        public readonly ICategory _icategory;
        public CategoryController(ICategory icategory)
        {
            _icategory = icategory;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Categories>>> GetAllCategories()
        {
            var data=await _icategory.GetAllAsync();
            return Ok(data);
        }
        [HttpGet("{Id}")]
        public async Task<ActionResult<Categories>>GetbyId(int Id)
        {
           return await _icategory.GetCategoriesById(Id);
        }
        [HttpPut("{Id}")]
        public async Task <IActionResult>Update(Categories categories,int Id)
        {
            if (Id == categories.Id)
            {
                await _icategory.EditCategoriesAsync(categories);
                return Ok("Edited successfully");
            }
            return BadRequest("Cannot be updated");
        }
        [HttpDelete("{Id}")]
        public async Task<IActionResult> Delete(int Id)
        {
            var data = await _icategory.GetCategoriesById(Id);
            if (data == null)
            {
                return NotFound();
            }
            await _icategory.DeleteCategoriesAsync(Id);
            return Ok("Deleted successfully");

        }
        [HttpPost]
        public async Task <ActionResult> AddAllCategory(Categories categories)
        {
            if (categories == null)
            {
                return BadRequest("!!! Must add categories !!!");
            }
            await _icategory.AddAllAsync(categories);
            return Ok("Added successfully");
        }

       
    }
}
