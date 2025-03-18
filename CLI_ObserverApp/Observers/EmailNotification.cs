using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CLI_ObserverApp.Interfaces;

namespace CLI_ObserverApp.Observers
{
    public class EmailNotification : IObserver
    {
        public void Update(string message)
        {
            Console.WriteLine($"EmailNotification: {message}");
        }
    }
}
