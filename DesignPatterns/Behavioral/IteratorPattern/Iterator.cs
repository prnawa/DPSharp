namespace DesignPatterns.Behavioral.IteratorPattern
{
    public abstract class Iterator
    {
        public abstract object First();
        public abstract object Next();
        public abstract object CurrentItem();
        public abstract bool IsDone();
    }

    public class ConcreteIterator : Iterator
    {
        private readonly ConcreteAggregate _aggregate;
        private int _current;

        public ConcreteIterator(ConcreteAggregate aggregate)
        {
            _aggregate = aggregate;
        }

        public override object First()
        {
            return _aggregate[0];
        }

        public override object Next()
        {
            return _current < _aggregate.Count - 1 ? _aggregate[++_current] : null;
        }

        public override object CurrentItem()
        {
            return _aggregate[_current];
        }

        public override bool IsDone()
        {
            return _current >= _aggregate.Count - 1;
        }
    }
}
