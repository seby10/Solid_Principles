using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Inversion_Principle_Correct;

public class SMSSender : IMessageSender
{
    public void SendMessage(string message, string receiver)
    {
        Console.WriteLine($"SMS sent to {receiver}:\n -> {message}");

    }
}
