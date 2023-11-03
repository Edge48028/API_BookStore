using API_BookStore.Models;

namespace API_BookStore.Repositories
{
    public interface ICategoryRepository
    {
        List<CategoryVM> GetAll();
        CategoryVM GetByID(int id);
        CategoryVM GetAdd(CategoryModel category);
        void Update(CategoryVM category);
        void Remove(int id);
    }
}
