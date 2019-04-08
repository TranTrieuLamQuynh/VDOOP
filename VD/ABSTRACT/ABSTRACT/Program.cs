using System;

namespace ABSTRACT
{
    class ABSTRACT
    {
        private double length;
        private double width;

        public void Input()
        {
            Console.WriteLine("Nhap Length: ");
            length = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Nhap Width: ");
            width = Convert.ToDouble(Console.ReadLine());
        }
        public double Dientich()
        {
            return length * width;
        }
        public void Show()
        {
            Console.WriteLine("Length: {0}", length);
            Console.WriteLine("Width: {0}", width);
            Console.WriteLine("Area: {0}", Dientich());
        }
    }

    class Test
    {
        static void Main(string[] args)
        {
            ABSTRACT r = new ABSTRACT();
            r.Input();
            r.Show();
            Console.ReadLine();
        }
    }
}

