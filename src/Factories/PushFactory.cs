using DesignPatternChallenge.Interfaces;
using DesignPatternChallenge.Products;

namespace DesignPatternChallenge.Factories
{
    public class PushFactory : NotificationFactory
    {
        public override INotification Create(string recipient, string message, string subject = null)
        {
            return new PushNotification
            {
                DeviceToken = recipient,
                Title = subject ?? "Nova Notificação",
                Message = message,
                Badge = 1
            };
        }
    }
}
