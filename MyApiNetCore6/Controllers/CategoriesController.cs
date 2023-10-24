using API_BookStore.Data;
using API_BookStore.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyApiNetCore6.Data;
using System.Runtime.ConstrainedExecution;

namespace API_BookStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly BookStoreContext _bookStoreContext;

        public CategoriesController(BookStoreContext context)
        {
            _bookStoreContext = context;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var ListCategory = _bookStoreContext.Categories.ToList();
            return Ok(ListCategory);
        }

        [HttpGet("{Id}")]
        public IActionResult GetById(int Id)
        {
            var Category = _bookStoreContext.Categories.SingleOrDefault(lo => lo.TypeCode == Id);
            if (Category != null) 
            {
                return Ok(Category);
            }
            else 
            { 
                return NotFound(); 
            }   
        }
        [HttpPost]
        public IActionResult CreateCategory(CategoryModel model) 
        {
            try
            {
                var category = new Category
                {
                    TypeName = model.TypeName
                };
           
                _bookStoreContext.Add(category);
                _bookStoreContext.SaveChanges();
                return Ok(category);
            }
            catch
            {
                return BadRequest();
            }
        }
        [HttpPut("{Id}")]
        public IActionResult UpdateCategoryByID(int Id, CategoryModel model)
        {
            var Category = _bookStoreContext.Categories.SingleOrDefault(lo => lo.TypeCode == Id);
            if (Category != null)
            {
                Category.TypeName = model.TypeName;
                _bookStoreContext.SaveChanges();
                return Ok("Update Successfull");
            }
            else
            {
                return NotFound();
            }
        }
        [HttpDelete("{Id}")]
        public IActionResult DeleteCategory(int Id)
        {
            var Category = _bookStoreContext.Categories.SingleOrDefault(lo => lo.TypeCode == Id);
            if (Category != null)
            {
                _bookStoreContext.Categories.Remove(Category);
                _bookStoreContext.SaveChanges();
                return Ok("Delete Successful");
            }
            else
            {
                return NotFound();
            }
        }

    }
}
