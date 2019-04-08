using System;

namespace Inheritance
{
    class Inheritance
    {
        public void Width(int w)
        {
            width = w;
        }
        public void Height(int h)
        {
            hight = h;
        }
        protected int width;
        protected int hight;

    }
    class Tinhdientich : Inheritance
    {
        public int Dientich()
    {
            return (width * hight);
    }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Tinhdientich s = new Tinhdientich();
            s.Height(10);
            s.Width(5);
            Console.WriteLine("Dien tich la: {0}", s.Dientich());
            Console.ReadKey();
        }
    }
}
