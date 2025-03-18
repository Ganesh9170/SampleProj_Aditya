using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CLI_ObserverApp.Interfaces;
using CLI_ObserverApp.Observers;

namespace CLI_ObserverApp.Factories
{
    public static class NotificationFactory
    {
        public static IObserver CreateNotification(string type)
        {
            return type.ToLower() switch
            {
                "email" => new EmailNotification(),
                "sms" => new SMSNotification(),
                "push" => new PushNotification(),
                _ => throw new ArgumentException("Invalid notification type!!")
            };
        }
    }
}
