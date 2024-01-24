
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventAggregatorDoor
{
    public class Timer
    {
        private SmartDoor door;
        EventAggregator eventAggregator;

        public Timer(SmartDoor Door, EventAggregator eventAggregator)
        {
            this.door = Door;
            this.eventAggregator = eventAggregator;
            this.eventAggregator.Subscribe<DoorEventArgs>(StartTimer);
        }



        public void StartTimer(EventArgs eventArgs)
        {
            DoorEventArgs doorEventArgs = (DoorEventArgs)eventArgs;
            if (this.door.state = DoorStates.OPEN)
            {
                Thread timerThread = new Thread(() =>
                {
                    Thread.Sleep(door.doorTimeThreshold * 1000);

                    if (door.state == DoorStates.OPEN) eventAggregator.Publish(new ThresholdReachedEvent()); ;

                });
                timerThread.Start();
            }
        }
    }


    }
