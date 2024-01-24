using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventAggregatorDoor
{
    public class AutoClose
    {
        public   void Alert(SmartDoor Door) 
        {
            Door.Close();
            Logger.Write($"Door {Door.name} has been closed");
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
