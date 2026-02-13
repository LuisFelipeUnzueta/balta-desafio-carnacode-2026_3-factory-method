using System;
using DesignPatternChallenge.Factories;

namespace DesignPatternChallenge.Services
{
    public class NotificationService
    {
        public void SendOrderConfirmation(NotificationFactory factory, string recipient, string orderNumber)
        {
            var subject = "Confirmação de Pedido";
            var message = $"Seu pedido {orderNumber} foi confirmado!";
            
            // O Factory decide como criar a notificação específica
            var notification = factory.Create(recipient, message, subject);
            notification.Send();
        }

        public void SendShippingUpdate(NotificationFactory factory, string recipient, string trackingCode)
        {
            var subject = "Pedido Enviado";
            var message = $"Seu pedido foi enviado! Código de rastreamento: {trackingCode}";

            var notification = factory.Create(recipient, message, subject);
            notification.Send();
        }

        public void SendPaymentReminder(NotificationFactory factory, string recipient, decimal amount)
        {
            var subject = "Lembrete de Pagamento";
            var message = $"Você tem um pagamento pendente de R$ {amount:N2}";

            var notification = factory.Create(recipient, message, subject);
            notification.Send();
        }
    }
}
