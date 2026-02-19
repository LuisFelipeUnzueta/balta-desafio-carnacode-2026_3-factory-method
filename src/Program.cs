using System;
using DesignPatternChallenge.Factories;
using DesignPatternChallenge.Services;

namespace DesignPatternChallenge
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== Notification System (Factory Method) ===\n");



            // Client 1 prefers Email
            Console.WriteLine("--- Client 1 (Email) ---");
            var emailFactory = new EmailFactory();
            NotificationService.SendOrderConfirmation(emailFactory, "cliente@email.com", "12345");
            Console.WriteLine();

            // Client 2 prefers SMS
            Console.WriteLine("--- Client 2 (SMS) ---");
            var smsFactory = new SmsFactory();
            NotificationService.SendOrderConfirmation(smsFactory, "+5511999999999", "12346");
            Console.WriteLine();

            // Client 3 prefers Push
            Console.WriteLine("--- Client 3 (Push) ---");
            var pushFactory = new PushFactory();
            NotificationService.SendShippingUpdate(pushFactory, "device-token-abc123", "BR123456789");
            Console.WriteLine();

            // Client 4 prefers WhatsApp
            Console.WriteLine("--- Client 4 (WhatsApp) ---");
            var whatsappFactory = new WhatsAppFactory();
            NotificationService.SendPaymentReminder(whatsappFactory, "+5511888888888", 150.00m);
            Console.WriteLine();
        }
    }
}
