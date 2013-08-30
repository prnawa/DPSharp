using System;

namespace DesignPatterns.AbstractFactoryPattern
{
    public class Client
    {
        private readonly AbstarctProductA _productA;
        private readonly AbstarctProductB _productB;

        public Client(AbstractFactory factory)
        {
            _productA = factory.CreateProductA();
            _productB = factory.CreateProductB();
        }

        public void Run()
        {
            Console.WriteLine(string.Format("{0} {1}",_productA.GetType(), _productB.GetType()));
        }
    }
}
