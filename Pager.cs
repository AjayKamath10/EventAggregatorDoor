using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventAggregatorDoor
{
    public class Pager
    {
        public void Alert(SmartDoor door)
        {
            Logger.Write($"Pager: door {door.name} is open");
        }
        public void Subscribe(SmartDoor door)
        {
            door.TimerThresholdReachedEvent += this.Alert;
        }

        public void UnSubscribe(SmartDoor door)
        {
            door.TimerThresholdReachedEvent -= this.Alert;
        }
    }
}
