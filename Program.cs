using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L_20
{
    class Program
    {
        delegate double MyDelegate(double r);

        static void Main(string[] args)
        {
            MyDelegate myDelegate = Lenght;
            if (myDelegate != null)
            {
                double res = myDelegate(10);
                Console.WriteLine($"Длина окружности {res:F2}");
            }
            myDelegate  = Square;
            if (myDelegate != null)
            {
                double res = myDelegate(10);
                Console.WriteLine($"Площадь круга {res:F2}");
            }
            myDelegate = Volume;
            if (myDelegate != null)
            {
                double res = myDelegate(10);
                Console.WriteLine($"Объем шара {res:F2}");
            }
            Console.ReadKey();
        }
        static double Lenght(double r)
        {
            return 2 * Math.PI * r;
        }
        static double Square(double r)
        {
            return Math.PI * r * r;
        }
        static double Volume(double r)
        {
            return Math.PI * Math.Pow(r, 3) * (4 / 3);
        }


    }
}
