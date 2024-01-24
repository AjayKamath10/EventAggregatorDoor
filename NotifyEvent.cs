using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Sent from Smart Door -> all devices

namespace EventAggregatorDoor
{
    public class NotifyEvent : EventArgs
    {
        public SmartDoor door { get; }

        public NotifyEvent(SmartDoor door)
        {
            this.door = door;
        }
    }
}
