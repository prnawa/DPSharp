namespace DesignPatterns.Creational.FactoryMethod
{
    public abstract class Creator
    {
        public abstract Product FatoryMethod();
    }

    public class CreatorA : Creator
    {
        public override Product FatoryMethod()
        {
            return new ProductA();
        }
    }

    public class CreatorB : Creator
    {
        public override Product FatoryMethod()
        {
            return new ProductB();
        }
    }
}