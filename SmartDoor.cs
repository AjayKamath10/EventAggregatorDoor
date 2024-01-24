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
        public event Action <SmartDoor> TimerThresholdReachedEvent;
        
        public Timer timer { get; private set; }
        

        public int doorTimeThreshold = 3;
        private EventAggregator eventAggregator;
        public SmartDoor(string Name, EventAggregator eventAggregator, double Price = 200) : base(Name, Price)
        {
            price += CalculateAdditionalPrice(this);
            timer = new Timer(this, eventAggregator);//remove event and call method directly
            this.eventAggregator = eventAggregator;
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

        public void ThresholdReached()
        {
            
        }

        private static double CalculateAdditionalPrice(SmartDoor This)
        {
            double additionalPrice = 0;

            return additionalPrice;
        }
    }
}
