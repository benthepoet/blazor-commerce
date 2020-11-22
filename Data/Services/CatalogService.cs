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

        public Task<Models.Category[]> GetCategories()
        {
            return _context.Category.ToArrayAsync();
        }

        public Task<Models.Category> GetCategoryWithProducts(int id)
        {
            return _context.Category
                .Include(x => x.Products)
                .ThenInclude(x => x.ProductVariants)
                .SingleAsync(x => x.Id == id);
        }

        public Task<Models.Product> GetProductWithVariants(int id) {
            return _context.Product
                .Include(x => x.ProductVariants)
                .SingleAsync(x => x.Id == id);
        }
    }
}
