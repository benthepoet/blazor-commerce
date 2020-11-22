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

        public Task CreateOrder(Models.Order order)
        {
            _context.Order.Add(order);
            return _context.SaveChangesAsync();
        }
    }
}