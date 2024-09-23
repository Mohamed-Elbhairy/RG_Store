using Entities;
using Microsoft.EntityFrameworkCore;
using RG_Store.DAL.DB;
using RG_Store.DAL.Entities;
using RG_Store.DAL.Repo.Abstraction;

namespace RG_Store.DAL.Repo.Implementation
{
    public class CategoryRepo : ICategoryRepo
    {
        private readonly ApplicationDbContext context;

        public CategoryRepo(ApplicationDbContext context)
        {
            this.context = context;
        }

        public Task<bool> AddToCategory(Item category, int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Create(Category category)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(Category category)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Category>> GetAll()
        {
            return await context.Categories.ToListAsync();
        }

        public async Task<IEnumerable<Item>> GetAllItems(int id)
        {
            var items = await context.CategoryItems
                .Include(i => i.Item)
                .Where(i => i.CategoryId == id)
                .Select(i => i.Item)
                .ToListAsync();
            return items; 
        }
        public async Task<Category> GetById(int id)
        {
            return await context.Categories.FirstOrDefaultAsync(c => c.Id == id);
        }

        public Task<bool> RemoveFromCategory(Item category, int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Update(Category category)
        {
            throw new NotImplementedException();
        }
    }
}
