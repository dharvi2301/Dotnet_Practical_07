using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Notifications;

namespace ConsoleApp1.Services
{
    public class HRService
    {
        private readonly IEmailNotifier _notifier;
        /// <summary>
        /// Constructor that injects a notification mechanism.
        /// </summary>
        public HRService(IEmailNotifier notifier)
        {
            _notifier = notifier;
        }
        /// <summary>
        /// Sends a notification to an employee.
        /// </summary>
        public void NotifyEmployee(string message)
        {
            _notifier.Notify(message);
        }
    }
}
