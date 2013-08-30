namespace DesignPatterns.Creational.SingletonPattern.StaticInitialization
{
    // http://msdn.microsoft.com/en-us/library/ff650316.aspx
    // the instance is created the first time any member of the class is referenced
    // The class is marked sealed to prevent derivation, which could add instances.
    // marked readonly, which means that it can be assigned only during static initialization or in a class constructor.
    // relies on the common language runtime to initialize the variable.
    // the instantiation does not occur until the class is first referenced by a call to the Instance property. This solution therefore implements a form of the lazy instantiation property
    // the only potential downside of this approach is that you have less control over the mechanics of the instantiation(nondefault constructor or perform other tasks before the instantiation).
    public sealed class Singleton
    {
        private static readonly Singleton _instance = new Singleton();

        private Singleton() {}

        public static Singleton Instance()
        {
            return _instance;
        }

    }
}
