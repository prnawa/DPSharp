namespace DesignPatterns.AbstractFactoryPattern
{
    public class Factory2 : AbstractFactory
    {
        public override AbstarctProductA CreateProductA()
        {
            return new ProductA2();
        }

        public override AbstarctProductB CreateProductB()
        {
            return new ProductB2();
        }
    }
}