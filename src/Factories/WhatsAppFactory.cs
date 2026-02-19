using DesignPatternChallenge.Interfaces;
using DesignPatternChallenge.Products;

namespace DesignPatternChallenge.Factories
{
    public class WhatsAppFactory : NotificationFactory
    {
        public override INotification Create(string recipient, string message, string? subject = null)
        {
            return new WhatsAppNotification
            {
                PhoneNumber = recipient,
                Message = message,
                UseTemplate = true
            };
        }
    }
}
