using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorCommerce.Data.Services
{
    public class CategoryService
    {
        private readonly DataContext _context;

        public CategoryService(DataContext context)
        {
            _context = context;
        }

        public Task<List<Models.Category>> GetCategories()
        {
            return _context.Category.ToListAsync();
        }
    }
}