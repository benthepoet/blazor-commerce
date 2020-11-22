using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BlazorCommerce.Data.Services
{
    public class UserService
    {
        private readonly DataContext _context;

        public UserService(DataContext context)
        {
            _context = context;
        }

        public Task CreateUserAddress(Models.UserAddress userAddress)
        {
            _context.UserAddress.Add(userAddress);
            return _context.SaveChangesAsync();
        }

        public Task<Models.UserAddress[]> GetUserAddresses(int userId)
        {
            return _context.UserAddress
                .Where(x => x.UserId == userId)
                .ToArrayAsync();
        }
    }
}