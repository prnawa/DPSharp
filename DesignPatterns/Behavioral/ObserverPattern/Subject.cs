using System.Collections.Generic;

namespace DesignPatterns.Behavioral.ObserverPattern
{
    public abstract class Subject
    {
        private readonly IList<Observer> _observers = new List<Observer>();

        public void Attach(Observer observer)
        {
            _observers.Add(observer);
        }

        public void Detach(Observer observer)
        {
            _observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (var observer in _observers)
            {
                observer.Update();
            }
        }
    }

    public class ConcreteSubject : Subject
    {
        public string State { get; set; }        
    }
}
