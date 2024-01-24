namespace EventAggregatorDoor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EventAggregator eventAggregator = EventAggregator.Instance;

            SimpleDoor Door1 = new SimpleDoor("Door1",eventAggregator);
            SmartDoor Door2 = new SmartDoor("Door2", eventAggregator);
            Timer TimerObj = new Timer(Door2, eventAggregator);
            Buzzer BuzzerObj = new Buzzer(eventAggregator);
            Pager PagerObj = new Pager(eventAggregator);
            AutoClose autoClose = new AutoClose(eventAggregator);

            Door2.Open();


        }
    }
}
