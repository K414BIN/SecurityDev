﻿namespace Patterns
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            var obj2 = SimpleSingleton.Instance;
            obj2.Counter++;

        }
    }

    class SimpleSingleton
    {
        private static SimpleSingleton? _instance;

        SimpleSingleton() { }

        public int Counter { get; set; } = 1;

        public static SimpleSingleton Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new SimpleSingleton();
                return _instance;
            }
        }

    }
}