using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Inversion_Principle_Correct;

public class NotificationService
{
    private IMessageSender _messageSender;

    public NotificationService(IMessageSender messageSender) => _messageSender = messageSender;

    // this is the high-level class that uses the low level one, following the principle
    public void SendNotification(string message, string receiver)
    {
        _messageSender.SendMessage(message, receiver);
    }
}
