namespace DesignPatterns.Behavioral.ObserverPattern
{
    public class Context
    {
        private Stratergy _stratergy;

        public void ContextInterface()
        {
            _stratergy.AlgorithmInterface();
        }

        public void SetStratergy(Stratergy stratergy)
        {
            _stratergy = stratergy;
        }
    }
}
