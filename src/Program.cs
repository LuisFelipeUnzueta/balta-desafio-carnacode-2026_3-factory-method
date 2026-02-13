using System;
using DesignPatternChallenge.Factories;
using DesignPatternChallenge.Services;

namespace DesignPatternChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Sistema de Notificações (Factory Method) ===\n");

            var service = new NotificationService();

            // Cliente 1 prefere Email
            Console.WriteLine("--- Cliente 1 (Email) ---");
            var emailFactory = new EmailFactory();
            service.SendOrderConfirmation(emailFactory, "cliente@email.com", "12345");
            Console.WriteLine();

            // Cliente 2 prefere SMS
            Console.WriteLine("--- Cliente 2 (SMS) ---");
            var smsFactory = new SmsFactory();
            service.SendOrderConfirmation(smsFactory, "+5511999999999", "12346");
            Console.WriteLine();

            // Cliente 3 prefere Push
            Console.WriteLine("--- Cliente 3 (Push) ---");
            var pushFactory = new PushFactory();
            service.SendShippingUpdate(pushFactory, "device-token-abc123", "BR123456789");
            Console.WriteLine();

            // Cliente 4 prefere WhatsApp
            Console.WriteLine("--- Cliente 4 (WhatsApp) ---");
            var whatsappFactory = new WhatsAppFactory();
            service.SendPaymentReminder(whatsappFactory, "+5511888888888", 150.00m);
            Console.WriteLine();
        }
    }
}
