using PizzaNet.Application.DTOs;

namespace PizzaNet.Application.Interfaces
{
    public interface ICategoryService
    {
        Task<IEnumerable<CategoryToReturnDTO>> GetAllCategoriesAsync();
    }
}
