using System;
using FormsDesktop.MacOS;
using FormsDesktop.Services;
using Foundation;
using Xamarin.Forms;

[assembly: Dependency(typeof(MacOsNotifyService))]
namespace FormsDesktop.MacOS
{
    public class MacOsNotifyService : INotifyService
    {
        public void Notify(string title, string text)
        {
            // Trigger a local notification after the time has elapsed
            var notification = new NSUserNotification();

            // Add text and sound to the notification
            notification.Title = title;
            notification.InformativeText = text;
            notification.SoundName = NSUserNotification.NSUserNotificationDefaultSoundName;
            notification.HasActionButton = true;
            NSUserNotificationCenter.DefaultUserNotificationCenter.DeliverNotification(notification);
        }
    }
}
