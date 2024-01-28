using petcare.Domain;
using petcare.Persistence.Repositories;

namespace petcare.Application.Commands
{
    public class CreateNotificationCommand
    {
        private readonly INotificationRepository _notificationRepository;

        public CreateNotificationCommand(INotificationRepository notificationRepository)
        {
            _notificationRepository = notificationRepository;
        }

        public async Task<Notification> Create(Notification notification)
        {
            return await _notificationRepository.AddAsync(notification);
        }
    }
}
