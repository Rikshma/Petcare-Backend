using petcare.Domain;

namespace petcare.Persistence.Repositories
{
    public interface IPetRepository
    {
        Task<Pet> AddAsync(Pet pet);
    }
}
