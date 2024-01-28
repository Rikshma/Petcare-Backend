using petcare.Domain;

namespace petcare.Persistence.Repositories
{
    public interface INotificationRepository
    {
        Task<Notification> AddAsync(Notification notification);
    }
}
