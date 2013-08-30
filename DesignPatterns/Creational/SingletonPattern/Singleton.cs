﻿namespace DesignPatterns.Creational.SingletonPattern
{
    public class Singleton
    {
        private static Singleton _instance;

        private Singleton(){}

        public static Singleton Instance()
        {
            // Uses lazy initialization.
            // Note: this is not thread safe.
            if(_instance == null)
            {
                _instance = new Singleton();
            }

            return _instance;
        }
    }
}
