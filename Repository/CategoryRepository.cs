using Microsoft.EntityFrameworkCore;
using StoreApi.Data;
using StoreApi.Models;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Http.HttpResults;

namespace StoreApi.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly AppDbContext _appDbcontext;
        public CategoryRepository(AppDbContext appDbContext)
        {
            _appDbcontext = appDbContext;
        }
        public async Task AddAllAsync(Categories category)
        {
            await _appDbcontext.ProductCategories.AddAsync(category);
            await _appDbcontext.SaveChangesAsync();
        }

        public async Task DeleteAllAsync(int Id)
        {
            var data=await GetByIdAsync(Id);
            if (data != null)
            {
                _appDbcontext.ProductCategories.Remove(data);
                await _appDbcontext.SaveChangesAsync();
            }
            
        }

        public async Task EditAllAsync(Categories category)
        {
             _appDbcontext.ProductCategories.Update(category);
            await _appDbcontext.SaveChangesAsync();   
        }

        public async Task<IEnumerable<Categories>> GetAllAsync()
        {
            return await _appDbcontext.ProductCategories.ToListAsync();
        }

        public async Task<Categories> GetByIdAsync(int Id)
        {
            return await _appDbcontext.ProductCategories.FindAsync(Id);
        }
    }
}
