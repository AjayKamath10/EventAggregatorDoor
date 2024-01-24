using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventAggregatorDoor
{
    public class Buzzer
    {
        private EventAggregator eventAggregator;
        public Buzzer(EventAggregator eventAggregator) 
        {
            this.eventAggregator = eventAggregator;
            this.eventAggregator.Subscribe<NotifyEvent>(Alert);
        }

        public void Alert(EventArgs eventArgs)
        {
            NotifyEvent notifyEvent = (NotifyEvent)eventArgs;
            Logger.Write($"Buzzer: door {notifyEvent.door.name} is open");
        }

    }
}
