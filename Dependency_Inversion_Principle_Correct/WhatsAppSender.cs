using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Inversion_Principle_Correct;

public class WhatsAppSender : IMessageSender
{
    public void SendMessage(string message, string receiver)
    {
        Console.WriteLine($"WhatsApp sent to {receiver}:\n -> {message}");

    }
}
