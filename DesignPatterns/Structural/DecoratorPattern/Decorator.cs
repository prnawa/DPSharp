namespace DesignPatterns.Structural.DecoratorPattern
{
    public abstract class Decorator : Component
    {
        private Component _component;

        public void SetComponent(Component component)
        {
            _component = component;
        }

        public override void Operation()
        {
            if (_component != null)
                _component.Operation();
        }
    }

    public class ConcreateDecoratorA : Decorator
    {
        public override void Operation()
        {
            base.Operation();
            AddedBehavior();
        }

        private void AddedBehavior() { }
    }

    public class ConcreateDecoratorB : Decorator
    {
        public override void Operation()
        {
            base.Operation();
            AddedBehavior();
        }

        private void AddedBehavior() { }
    }
}