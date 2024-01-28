using petcare.Domain;

namespace petcare.Persistence.Repositories
{
    public class PetRepository: IPetRepository
    {
        private readonly PetDbContext _context;

        public PetRepository(PetDbContext context)
        {
            _context = context;
        }

        public async Task<Pet> AddAsync(Pet pet)
        {
            _context.Set<Pet>().Add(pet);
            await _context.SaveChangesAsync();
            return pet;
        }
    }
}
