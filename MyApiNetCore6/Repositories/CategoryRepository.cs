using System;
using System.Collections.Generic;
using System.Linq;
using API_BookStore.Data;
using API_BookStore.Models;
using Microsoft.Build.Framework;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using MyApiNetCore6.Data;

namespace API_BookStore.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly BookStoreContext _context;

        public CategoryRepository(BookStoreContext context)
        {
            _context = context;
        }

        public CategoryVM GetAdd(CategoryModel category)
        {
            var newCategory = new Category
            {
                TypeName = category.TypeName
            };
            _context.Categories.Add(newCategory);
            _context.SaveChanges();

            var categoryVM = new CategoryVM
            {
                TypeCode = newCategory.TypeCode,
                TypeName = newCategory.TypeName
            };

            return categoryVM;
        }

        public List<CategoryVM> GetAll()
        {
            var categories = _context.Categories.Select(category => new CategoryVM
            {
                TypeCode = category.TypeCode,
                TypeName = category.TypeName
            });

            return categories.ToList();
        }

        public CategoryVM GetByID(int id)
        {
            var category = _context.Categories.SingleOrDefault(category => category.TypeCode == id);
            if (category != null)
            {
                return new CategoryVM
                {
                    TypeCode = category.TypeCode,
                    TypeName = category.TypeName
                };
                    
            }

            return null;

        }
        public CategoryVM Add(CategoryModel category)
        {
            var newCategory = new Category
            {
                TypeName = category.TypeName
            };
            _context.Categories.Add(newCategory);
            _context.SaveChanges();

            return new CategoryVM
            {
                TypeCode = newCategory.TypeCode,
                TypeName = newCategory.TypeName
            };
        }
        public void Update(CategoryVM category)
        {
            var _Category = _context.Categories.SingleOrDefault(c => c.TypeCode == category.TypeCode);
            if (_Category != null)
            {
                _Category.TypeName = category.TypeName;
                _context.SaveChanges();
            }
        }
        public void Remove(int id)
        {
            var category = _context.Categories.SingleOrDefault(category => category.TypeCode == id);
            if( category !=null)
            {
                _context.Remove(category);
                _context.SaveChanges();
            } 
        }
    }
}
