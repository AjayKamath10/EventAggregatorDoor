using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventAggregatorDoor
{
    public class AutoClose
    {
        private EventAggregator eventAggregator;
        public AutoClose(EventAggregator eventAggregator)
        {
            this.eventAggregator = eventAggregator;
            this.eventAggregator.Subscribe<NotifyEvent>(Alert);
        }

        public void Alert(EventArgs eventArgs)
        {
            NotifyEvent notifyEvent = (NotifyEvent)eventArgs;
            notifyEvent.door.Close();
            Logger.Write($"Door {notifyEvent.door.name} has been closed");

        }

    }
}
