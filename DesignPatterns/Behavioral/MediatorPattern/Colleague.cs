namespace DesignPatterns.Behavioral.MediatorPattern
{
    public abstract class Colleague
    {
        protected Mediator Mediator;

        protected Colleague(Mediator mediator)
        {
            Mediator = mediator;
        }        
    }

    public class ConcreteColleague : Colleague
    {
        public ConcreteColleague(Mediator mediator) : base(mediator)
        {
        }

        public void Notify(string message)
        {
            
        }

        public void Send(string message)
        {
            Mediator.Send(message,this);
        }
    }
}