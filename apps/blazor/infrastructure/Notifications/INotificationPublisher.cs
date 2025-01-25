using budget_request_app.Blazor.Shared.Notifications;

namespace budget_request_app.Blazor.Infrastructure.Notifications;

public interface INotificationPublisher
{
    Task PublishAsync(INotificationMessage notification);
}