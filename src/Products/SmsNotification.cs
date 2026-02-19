using System;
using DesignPatternChallenge.Interfaces;

namespace DesignPatternChallenge.Products
{
    public class SmsNotification : INotification
    {
        public required string PhoneNumber { get; set; }
        public required string Message { get; set; }

        public void Send()
        {
            Console.WriteLine($"📱 Sending SMS to {PhoneNumber}");
            Console.WriteLine($"   Message: {Message}");
        }
    }
}
