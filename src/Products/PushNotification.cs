using System;
using DesignPatternChallenge.Interfaces;

namespace DesignPatternChallenge.Products
{
    public class PushNotification : INotification
    {
        public required string DeviceToken { get; set; }
        public required string Title { get; set; }
        public required string Message { get; set; }
        public int Badge { get; set; }

        public void Send()
        {
            Console.WriteLine($"🔔 Sending Push to device {DeviceToken}");
            Console.WriteLine($"   Title: {Title}");
            Console.WriteLine($"   Message: {Message}");
        }
    }
}
