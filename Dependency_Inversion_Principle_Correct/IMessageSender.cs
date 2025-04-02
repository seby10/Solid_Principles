using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Inversion_Principle_Correct;

public interface IMessageSender
{
    void SendMessage(string message, string receiver);
}
