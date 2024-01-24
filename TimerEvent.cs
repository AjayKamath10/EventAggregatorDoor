using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventAggregatorDoor
{
    public class TimerEvent : EventArgs
    {
        public SmartDoor door { get; }

        public TimerEvent(SmartDoor door)
        {
            this.door = door;
        }
    }
}
