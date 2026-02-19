using DesignPatternChallenge.Interfaces;
using DesignPatternChallenge.Products;

namespace DesignPatternChallenge.Factories
{
    public class SmsFactory : NotificationFactory
    {
        public override INotification Create(string recipient, string message, string? subject = null)
        {
            return new SmsNotification
            {
                PhoneNumber = recipient,
                Message = message
            };
        }
    }
}
