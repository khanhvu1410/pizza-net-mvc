﻿namespace PizzaNet.Domain.Interfaces
{
    public interface IGenericRepository<T> where T : class
    {
        Task AddAsync(T entity);
        Task<IEnumerable<T>> GetAllAsync();
        Task<T?> GetByIdAsync(Guid id);
        void Update(T entity);
        Task DeleteAsync(Guid id);
        Task SaveChangesAsync();
    }
}
