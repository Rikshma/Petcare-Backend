using Microsoft.EntityFrameworkCore;
using petcare.Domain;

namespace petcare.Persistence.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly PetDbContext _context;

        public UserRepository(PetDbContext context)
        {
            _context = context;
        }

        public async Task<bool> CheckUserExists(string email)
        {
            return await _context.Users.AnyAsync(u => u.Email == email);

        }

        public async Task<User> AddAsync(User user)
        {
            _context.Set<User>().Add(user);
            await _context.SaveChangesAsync();
            return user;
        }
    }
}
