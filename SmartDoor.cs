using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventAggregatorDoor
{
    public class SmartDoor : SimpleDoor
    {    
        public int doorTimeThreshold = 3;

        public SmartDoor(string Name, EventAggregator eventAggregator, double Price = 200) : base(Name, eventAggregator, Price)
        {
            price += CalculateAdditionalPrice(this);
         
            this.eventAggregator.Subscribe<ThresholdReachedEvent>(ThresholdReached);
        }

        public void SetTimer(int Time)
        { 
            doorTimeThreshold = Time;
        }
            
        public override void Open()
        {
            base.Open();
            eventAggregator.Publish(new DoorEventArgs(this));
        }
        public override void Close()
        {
            base.Close();
            eventAggregator.Publish(new DoorEventArgs(this));
        }

        public void ThresholdReached(EventArgs eventArgs)
        {
            ThresholdReachedEvent thresholdReachedEvent = (ThresholdReachedEvent)eventArgs;
            eventAggregator.Publish(new NotifyEvent(thresholdReachedEvent.door));            
        }

        private static double CalculateAdditionalPrice(SmartDoor This)
        {
            double additionalPrice = 0;

            return additionalPrice;
        }
    }
}
