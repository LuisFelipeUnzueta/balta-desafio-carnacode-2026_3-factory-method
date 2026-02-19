using System;
using DesignPatternChallenge.Interfaces;

namespace DesignPatternChallenge.Products
{
    public class WhatsAppNotification : INotification
    {
        public required string PhoneNumber { get; set; }
        public required string Message { get; set; }
        public bool UseTemplate { get; set; }

        public void Send()
        {
            Console.WriteLine($"💬 Sending WhatsApp to {PhoneNumber}");
            Console.WriteLine($"   Message: {Message}");
            Console.WriteLine($"   Template: {UseTemplate}");
        }
    }
}
