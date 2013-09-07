using System.Collections;

namespace DesignPatterns.Behavioral.IteratorPattern
{
    public abstract class Aggregate
    {
        public abstract Iterator CreateIterator();
    }

    public class ConcreteAggregate : Aggregate
    {
        private readonly ArrayList _list = new ArrayList();

        public override Iterator CreateIterator()
        {
            return new ConcreteIterator(this);
        }

        public object this[int i]
        {
            get { return _list[i]; }
            set { _list.Insert(i, value); }
        }

        public int Count
        {
            get { return _list.Count; }
        }
    }
}
