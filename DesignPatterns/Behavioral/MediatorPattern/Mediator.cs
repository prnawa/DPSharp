using System.Collections.Generic;

namespace DesignPatterns.Behavioral.MediatorPattern
{
    public abstract class Mediator
    {
        public abstract void Send(string message, Colleague colleague);
    }

    public class ConcreteMediator : Mediator
    {
        private readonly IList<ConcreteColleague> _colleagues = new List<ConcreteColleague>();

        public override void Send(string message, Colleague colleague)
        {
            foreach (var currentColleague in _colleagues)
            {
                if (!colleague.Equals(currentColleague))
                    currentColleague.Notify(message);
            }
        }

        public void AddColleague(ConcreteColleague colleague)
        {
            _colleagues.Add(colleague);
        }
    }
}
