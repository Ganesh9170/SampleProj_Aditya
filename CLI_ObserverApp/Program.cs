using System;
using CLI_ObserverApp.Factories;
using CLI_ObserverApp.Interfaces;
using CLI_ObserverApp.Subjects;

namespace CLI_ObserverApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NotificationService notificationService = new NotificationService();

            IObserver emailObserver = NotificationFactory.CreateNotification("email");
            IObserver smsObserver = NotificationFactory.CreateNotification("sms");
            IObserver pushObserver = NotificationFactory.CreateNotification("push");

            notificationService.Attach(emailObserver);
            notificationService.Attach(smsObserver);
            notificationService.Attach(pushObserver);

            notificationService.Notify("Freshers' Communication Session at Zensar today at 3 PM!");

            notificationService.Detach(smsObserver);

            notificationService.Notify("Freshers' Communication Session has been rescheduled for tomorrow at Zensar 4 PM!");
        }
    }
}
