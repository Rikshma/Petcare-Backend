using Microsoft.EntityFrameworkCore;
using petcare.Domain;

namespace petcare.Persistence.Repositories
{
    public class NotificationRepository : INotificationRepository
    {
        private readonly PetDbContext _context;
        public NotificationRepository(PetDbContext context)
        {
            _context = context;
        }

        public async Task<Notification> AddAsync(Notification notification)
        {
            _context.Set<Notification>().Add(notification);
            await _context.SaveChangesAsync();
            return notification;
        }
    }
}
