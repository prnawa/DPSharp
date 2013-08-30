using System;

namespace DesignPatterns.Creational.SingletonPattern.Double_CheckLocking
{
    // the variable is declared to be volatile to ensure that assignment to the instance variable completes before the instance variable can be accessed.
    // uses a syncRoot instance to lock on, rather than locking on the type itself, to avoid deadlocks.
    // solves the thread concurrency problems while avoiding an exclusive lock in every call to the Instance property method. 
    // It also allows you to delay instantiation until the object is first accessed.
    public sealed class Singleton
    {
        private static volatile Singleton _instance;
        private static object syncRoot = new Object();

        private Singleton() {}

        public static Singleton Instance()
        {
            if(_instance == null)
            {
                lock (syncRoot)
                {
                    if (_instance == null)
                    {
                        _instance = new Singleton();
                    }
                }
            }

            return _instance;
        }
    }
}
