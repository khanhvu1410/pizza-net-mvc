using PizzaNet.Application.DTOs;
using PizzaNet.Application.Interfaces;
using PizzaNet.Application.Mappers;
using PizzaNet.Domain.Entities;
using PizzaNet.Domain.Interfaces;

namespace PizzaNet.Application.Services
{
    public class CategoryService : ICategoryService
    {
        private IGenericRepository<Category> _categoryRepository;

        public CategoryService(IGenericRepository<Category> categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public async Task<IEnumerable<CategoryToReturnDTO>> GetAllCategoriesAsync()
        {
            var categories = await _categoryRepository.GetAllAsync();
            return categories.Select(c => c.ToCategoryToReturnDTO());
        }
    }
}
