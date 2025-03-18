using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CLI_ObserverApp.Interfaces;

namespace CLI_ObserverApp.Subjects
{
    public class NotificationService : ISubject
    {
        List<IObserver> observers = new List<IObserver>();

        public void Attach(IObserver observer)
        {
            observers.Add(observer);
        }

        public void Detach(IObserver obeserver)
        {
            observers.Remove(obeserver);
        }

        public void Notify(string message)
        {
            foreach (var observer in observers)
            {
                observer.Update(message);
            }
        }
    }
}
