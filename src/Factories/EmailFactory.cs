using DesignPatternChallenge.Interfaces;
using DesignPatternChallenge.Products;

namespace DesignPatternChallenge.Factories
{
    public class EmailFactory : NotificationFactory
    {
        public override INotification Create(string recipient, string message, string subject = null)
        {
            return new EmailNotification
            {
                Recipient = recipient,
                Subject = subject ?? "Sem Assunto",
                Body = message,
                IsHtml = true
            };
        }
    }
}
