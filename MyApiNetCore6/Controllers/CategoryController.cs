using API_BookStore.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using API_BookStore.Models;

namespace API_BookStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryController(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            try
            {
                return Ok(_categoryRepository.GetAll());
            }
            catch
            {
                return StatusCode(500);
            }
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            try
            {
                var data = _categoryRepository.GetByID(id);
                if (data != null)
                {
                    return Ok(data);
                }
                else
                {
                    return NotFound();
                }
            }
            catch
            {
                return StatusCode(500);
            }
        }
        [HttpPost]
        public IActionResult CreateCategory(CategoryModel model)
        {
            try
            {
                return Ok(_categoryRepository.GetAdd(model));
            }
            catch
            {
                return StatusCode(500);
            }
        }
        [HttpPut("{id}")]
        public IActionResult Update(int id, CategoryVM category)
        {
            if (id != category.TypeCode)
            {
                return BadRequest();
            }
            try
            {
                _categoryRepository.Update(category);
                return Ok("Update Successful");
            }
            catch
            {
                return StatusCode(500);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                _categoryRepository.Remove(id);
                return Ok("Delete Successful");
            }
            catch
            {
                return StatusCode(500);
            }
        }
    }
}
