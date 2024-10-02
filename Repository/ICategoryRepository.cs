using StoreApi.Models;
using Microsoft.AspNetCore.Mvc;


namespace StoreApi.Repository
{
    public interface ICategoryRepository
    {
        Task<IEnumerable<Categories>> GetAllAsync();
        Task <Categories> GetByIdAsync(int Id);
        Task AddAllAsync(Categories category);
        Task EditAllAsync(Categories category);
        Task DeleteAllAsync(int Id);
    }
}
