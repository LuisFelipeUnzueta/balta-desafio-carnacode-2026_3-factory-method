using System;
using DesignPatternChallenge.Interfaces;

namespace DesignPatternChallenge.Products
{
    public class WhatsAppNotification : INotification
    {
        public string PhoneNumber { get; set; }
        public string Message { get; set; }
        public bool UseTemplate { get; set; }

        public void Send()
        {
            Console.WriteLine($"💬 Enviando WhatsApp para {PhoneNumber}");
            Console.WriteLine($"   Mensagem: {Message}");
            Console.WriteLine($"   Template: {UseTemplate}");
        }
    }
}
