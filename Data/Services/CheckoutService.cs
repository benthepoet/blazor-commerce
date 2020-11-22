using System.Linq;
using System.Threading.Tasks;

namespace BlazorCommerce.Data.Services
{
    public class CheckoutService
    {
        private readonly DataContext _context;

        public CheckoutService(DataContext context)
        {
            _context = context;
        }

        public Task CreateOrder(Models.Cart cart)
        {
            var order = new Models.Order {
                OrderLines = cart.CartLines
                    .Select(x => new Models.OrderLine {
                        ProductVariantId = x.ProductVariantId,
                        Quantity = x.Quantity
                    })
                    .ToList()
            };

            _context.Order.Add(order);
            return _context.SaveChangesAsync();
        }
    }
}