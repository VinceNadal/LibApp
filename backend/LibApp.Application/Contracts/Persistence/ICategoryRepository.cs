using LibApp.Domain.Entities;

namespace LibApp.Application.Contracts.Persistence;

public interface ICategoryRepository
{
  Task<List<Category>> GetCategories();
  Task<Category> GetCategoryById(int id);
  Task<Category> AddCategory(Category category);
  Task<Category> UpdateCategory(Category category);
  Task DeleteCategory(Category category);
}