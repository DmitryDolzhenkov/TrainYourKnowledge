using System;

namespace Override
{
    class Program
    {
        static void Main(string[] args)
        {
            var second = new Second();

            second.InsideFirst();
            second.InsideSecond();
        }
    }
    class First
    {
        public virtual void Method() => Console.WriteLine("first method");
        public void InsideFirst()
        {
            Method();
        }
    }
    class Second : First
    {
        public override void Method() => Console.WriteLine("second method");

        public void InsideSecond()
        {
            Method();
            base.Method();
        }
    }
}
