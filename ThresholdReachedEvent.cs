using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//sent from Timer -> SmartDoor
namespace EventAggregatorDoor
{
    public class ThresholdReachedEvent : EventArgs
    {
        public SmartDoor door{ get; }

        public ThresholdReachedEvent(SmartDoor door)
        {
            this.door = door;
        }
    }
}
