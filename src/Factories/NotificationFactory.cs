using DesignPatternChallenge.Interfaces;

namespace DesignPatternChallenge.Factories
{
    public abstract class NotificationFactory
    {
        public abstract INotification Create(string recipient, string message, string subject = null);
    }
}
