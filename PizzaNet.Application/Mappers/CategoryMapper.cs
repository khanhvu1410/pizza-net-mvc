using PizzaNet.Application.DTOs;
using PizzaNet.Domain.Entities;

namespace PizzaNet.Application.Mappers
{
    public static class CategoryMapper
    {
        public static CategoryToReturnDTO ToCategoryToReturnDTO(this Category category)
        {
            return new CategoryToReturnDTO
            {
                Id = category.Id,
                Name = category.Name,
            };
        }
    }
}
