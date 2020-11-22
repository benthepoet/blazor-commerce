using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace BlazorCommerce.Data.Services
{
    public class CartService
    {
        private readonly DataContext _context;

        public CartService(DataContext context) 
        {
            _context = context;
        }

        public Task CreateCart(Models.Cart cart) 
        {
            _context.Cart.Add(cart);
            return _context.SaveChangesAsync();
        }

        public Task CreateCartLine(Models.CartLine cartLine)
        {
            _context.CartLine.Add(cartLine);
            return _context.SaveChangesAsync();
        }

        public Task DeleteCartLine(Models.CartLine cartLine) {
            _context.CartLine.Remove(cartLine);
            return _context.SaveChangesAsync();
        }

        public Task<Models.Cart> GetCartWithLines(int id)
        {
            return _context.Cart
                .Include(x => x.CartLines)
                .SingleAsync(x => x.Id == id);
        }
    }
}