using StoreApi.Models;

namespace StoreApi.Services
{
    public interface ICategory
    {
        Task <IEnumerable<Categories>> GetAllAsync ();
        Task AddAllAsync (Categories categories);
        Task EditCategoriesAsync (Categories categories);
        Task DeleteCategoriesAsync(int Id);
        Task <Categories> GetCategoriesById(int Id); 
    }
}
