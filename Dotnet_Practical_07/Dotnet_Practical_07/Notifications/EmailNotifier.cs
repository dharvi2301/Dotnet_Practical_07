using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Notifications
{
    public class EmailNotifier:IEmailNotifier
    {
        /// <summary>
        /// Sends a notification message.
        /// </summary>
        public void Notify(string message) => Console.WriteLine("DIP>>>> Email Notification:" + message);
    }
}
