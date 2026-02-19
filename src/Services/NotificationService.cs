using System;
using DesignPatternChallenge.Factories;

namespace DesignPatternChallenge.Services
{
    public class NotificationService
    {
        public static void SendOrderConfirmation(NotificationFactory factory, string recipient, string orderNumber)
        {
            var subject = "Order Confirmation";
            var message = $"Your order {orderNumber} has been confirmed!";

            // The Factory decides how to create the specific notification
            var notification = factory.Create(recipient, message, subject);
            notification.Send();
        }

        public static void SendShippingUpdate(NotificationFactory factory, string recipient, string trackingCode)
        {
            var subject = "Order Shipped";
            var message = $"Your order has been shipped! Tracking code: {trackingCode}";

            var notification = factory.Create(recipient, message, subject);
            notification.Send();
        }

        public static void SendPaymentReminder(NotificationFactory factory, string recipient, decimal amount)
        {
            var subject = "Payment Reminder";
            var message = $"You have a pending payment of {amount:C2}";

            var notification = factory.Create(recipient, message, subject);
            notification.Send();
        }
    }
}
