using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorCommerce.Data.Services
{
    public class CatalogService
    {
        private readonly DataContext _context;

        public CatalogService(DataContext context)
        {
            _context = context;
        }

        public Task<List<Models.Category>> GetCategories()
        {
            return _context.Category.ToListAsync();
        }

        public Task<List<Models.Product>> GetProductsByCategory(int categoryId)
        {
            return _context.Product
                .Where(x => x.CategoryId == categoryId)
                .ToListAsync();
        }
    }
}
