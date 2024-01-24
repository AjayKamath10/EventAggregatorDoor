using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventAggregatorDoor
{
    public sealed class EventAggregator
    {
        private static readonly EventAggregator instance = new EventAggregator();
        private Dictionary<Type, List<Action<EventArgs>>> subscribers = new Dictionary<Type, List<Action<EventArgs>>>();

        private EventAggregator() { }

        public static EventAggregator Instance
        {
            get { return instance; }
        }

        public void Subscribe<T>(Action<EventArgs> subscriber) where T : EventArgs
        {
            Type eventType = typeof(T);
            if (!subscribers.ContainsKey(eventType))
            {
                subscribers[eventType] = new List<Action<EventArgs>>();
            }

            subscribers[eventType].Add(subscriber);
        }

        public void Publish<T>(T eventArgs) where T : EventArgs
        {
            Type eventType = typeof(T);
            if (subscribers.ContainsKey(eventType))
            {
                foreach (var subscriber in subscribers[eventType])
                {
                    subscriber.Invoke(eventArgs);
                }
            }
        }
    }
}
