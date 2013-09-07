namespace DesignPatterns.Structural.FacadePattern
{
    public class Facade
    {
        private readonly SubSystemA _subSystemA;
        private readonly SubSystemB _subSystemB;
        private readonly SubSystemC _subSystemC;

        public Facade(SubSystemA subSystemA, SubSystemB subSystemB, SubSystemC subSystemC)
        {
            _subSystemA = subSystemA;
            _subSystemB = subSystemB;
            _subSystemC = subSystemC;
        }

        public void MethodOne()
        {
            _subSystemA.MethodA();
            _subSystemC.MethodC();
        }

        public void MethodTwo()
        {
            _subSystemB.MethodB();
            _subSystemC.MethodC();
        }
    }

    public class SubSystemA 
    {
        public virtual void MethodA() {}
    }

    public class SubSystemB
    {
        public virtual void MethodB() { }
    }
    public class SubSystemC
    {
        public virtual void MethodC() { }
    }
}
