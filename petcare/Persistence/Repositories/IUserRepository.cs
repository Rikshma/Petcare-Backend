using petcare.Domain;

namespace petcare.Persistence.Repositories
{
    public interface IUserRepository
    {
        Task<bool> CheckUserExists(string email);
        Task<User> AddAsync(User user);
    }
}
