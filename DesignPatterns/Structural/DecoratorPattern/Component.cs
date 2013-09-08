namespace DesignPatterns.Structural.DecoratorPattern
{
    public abstract class Component
    {
        public abstract void Operation();
    }

    public class ConcreteComponent : Component
    {
        public override void Operation()
        {
        }
    }
}
