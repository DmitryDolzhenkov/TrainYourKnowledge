using System;
using System.Threading;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            (new Thread(() =>
            {
                Computer comp2 = new Computer();
                comp2.OS = OS.GetInstance("Windows 10");
                Console.WriteLine(comp2.OS.Name);
            })).Start();

            Computer comp1 = new Computer();
            
            comp1.Launch("Windows 8.1");
            Console.WriteLine(comp1.OS.Name);

            Thread.Sleep(500);
            Console.WriteLine(comp1.OS.Name);

            Console.WriteLine($"Main {DateTime.Now.TimeOfDay}");
            Console.WriteLine(Singleton.text);

            Singleton singleton1 = Singleton.GetInstance();
            Console.WriteLine(singleton1.Name);

            Singleton singleton2 = Singleton.GetInstance();
            Console.WriteLine(singleton2.Name);
            // Console.WriteLine(singleton1.Date);

            // Console.ReadLine();
        }

    }
    class Computer
    {
        public OS OS { get; set; }
        public void Launch(string osName)
        {
            OS = OS.GetInstance(osName);
        }
    }
    class OS
    {
        private static OS instance;
        public string Name { get; private set; }
        private static object syncRoot = new Object();

        protected OS(string name)
        {
            this.Name = name;
        }
        public static OS GetInstance(string osName)
        {
            if (instance == null)
            {
                lock (syncRoot)
                {
                    if (instance == null)
                    {
                        instance =  new OS(osName);
                    }
                }
            }
                
                
            return instance;
        }
    }
    public class Singleton
    {
        public static string text = "hello";
        private static readonly Lazy<Singleton> lazy = new Lazy<Singleton>(() => new Singleton());
        public string Name { get; private set; }
        private Singleton()
        {
            Name = System.Guid.NewGuid().ToString();
        }
        public static Singleton GetInstance()
        {
            return lazy.Value;
        }
    }
}
