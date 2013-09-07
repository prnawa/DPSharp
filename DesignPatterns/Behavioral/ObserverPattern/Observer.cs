namespace DesignPatterns.Behavioral.ObserverPattern
{
    public abstract class Observer
    {
        public abstract void Update();
    }

    public class ConcreteObserver : Observer
    {
        private readonly ConcreteSubject _subject;
        private string _state;

        public ConcreteObserver(ConcreteSubject subject)
        {
            _subject = subject;
        }

        public string State
        {
            get { return _state; }
        }

        public override void Update()
        {
            _state = _subject.State;
        }
    }
}
