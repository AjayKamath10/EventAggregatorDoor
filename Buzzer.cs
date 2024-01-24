using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventAggregatorDoor
{
    public class Buzzer
    {
        public void Alert(SmartDoor door)
        {
            Logger.Write($"Buzzer: door {door.name} is open");
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
