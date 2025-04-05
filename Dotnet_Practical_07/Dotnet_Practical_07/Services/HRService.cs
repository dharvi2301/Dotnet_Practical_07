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
        public HRService(IEmailNotifier notifier)
        {
            _notifier = notifier;
        }
        public void NotifyEmployee(string message)
        {
            _notifier.Notify(message);
        }
    }
}
