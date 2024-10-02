using StoreApi.Models;
using StoreApi.Repository;

namespace StoreApi.Services
{
    public class CategoryService : ICategory
    {
        private readonly ICategoryRepository _categoryrep;
        public CategoryService(ICategoryRepository categoryrep)
        {
            _categoryrep = categoryrep;
        }

        public async Task AddAllAsync(Categories categories)
        {
            await _categoryrep.AddAllAsync(categories);
        }

        public async Task DeleteCategoriesAsync(int Id)
        {
            await _categoryrep.DeleteAllAsync(Id);
        }

        public async Task EditCategoriesAsync(Categories categories)
        {
            await _categoryrep.EditAllAsync(categories);
        }

        public async Task<IEnumerable<Categories>> GetAllAsync()
        {
            return await _categoryrep.GetAllAsync();
        }

        public async Task<Categories> GetCategoriesById(int Id)
        {
            return await _categoryrep.GetByIdAsync(Id);
        }
    }
}
