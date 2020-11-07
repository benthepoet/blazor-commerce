using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorCommerce.Data.Services
{
    public class ProductService
    {
        private readonly DataContext _context;

        public ProductService(DataContext context)
        {
            _context = context;
        }

        public Task<List<Models.Product>> GetProducts(int categoryId)
        {
            return _context.Product
                .Where(x => x.CategoryId == categoryId)
                .ToListAsync();
        }
    }
}
