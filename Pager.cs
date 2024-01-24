using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventAggregatorDoor
{
    public class Pager
    {

        private EventAggregator eventAggregator;
        public Pager(EventAggregator eventAggregator)
        {
            this.eventAggregator = eventAggregator;
            this.eventAggregator.Subscribe<NotifyEvent>(Alert);
        }

        public void Alert(EventArgs eventArgs)
        {
            NotifyEvent notifyEvent = (NotifyEvent)eventArgs;
            Logger.Write($"Pager: door {notifyEvent.door.name} is open");
        }
    }
}
