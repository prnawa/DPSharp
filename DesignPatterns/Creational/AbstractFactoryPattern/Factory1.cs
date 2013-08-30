namespace DesignPatterns.AbstractFactoryPattern
{
    public class Factory1 : AbstractFactory
    {
        public override AbstarctProductA CreateProductA()
        {
            return new ProductA1();
        }

        public override AbstarctProductB CreateProductB()
        {
            return new ProductB1();
        }
    }
}