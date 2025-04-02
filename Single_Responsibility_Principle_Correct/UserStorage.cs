using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Single_Responsibility_Principle_Correct
{
    public class UserStorage
    {
        public void SaveDataBase(User user)
        {
            Console.WriteLine("Saving the user: " + user.Name + " with the email: " + user.Email + " in the Database...");
        }
    }
}
