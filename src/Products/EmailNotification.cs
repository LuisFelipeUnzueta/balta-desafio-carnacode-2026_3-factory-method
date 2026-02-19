using System;
using DesignPatternChallenge.Interfaces;

namespace DesignPatternChallenge.Products
{
    public class EmailNotification : INotification
    {
        public required string Recipient { get; set; }
        public required string Subject { get; set; }
        public required string Body { get; set; }
        public bool IsHtml { get; set; }

        public void Send()
        {
            Console.WriteLine($"📧 Sending Email to {Recipient}");
            Console.WriteLine($"   Subject: {Subject}");
            Console.WriteLine($"   Message: {Body}");
        }
    }
}
