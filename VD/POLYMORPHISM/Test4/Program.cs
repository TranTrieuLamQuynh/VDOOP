using System;

namespace Polymorphism
{
   
   
   
    abstract class A
    {
        public abstract int poly();
    }

    class Tinhdientich : A
    {
        private int length;
        private int width;

        public Tinhdientich(int a = 0, int b = 0)
        {
            length = a;
            width = b;
        }
        public override int poly()
        {
            Console.WriteLine("Rectangle class area :");
            return (width * length);
        }
    }
    class Test
    {
        static void Main(string[] args)
        {
            Tinhdientich r = new Tinhdientich(10, 7);
            double a = r.poly();
            Console.WriteLine("Dien tich la: {0}", a);
            Console.ReadKey();
    
        }
    }
}
