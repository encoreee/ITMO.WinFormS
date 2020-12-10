using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите коэффициенты");
            Console.Write("x^2 = ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("x = ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("c = ");
            double c = double.Parse(Console.ReadLine());

            int dd;
            double x1;
            double x2;
            if (Ur2.Deskr(a, b, c) >= 0)
            {
                dd = Ur2.Gg(a, b, c, out x1, out x2);
                Console.WriteLine(dd + "\n x1= {0} \n x2= {1}", x1, x2);
                Console.Read();
            }
            else
            {
                dd = -1;
                Console.WriteLine(dd + " \n Корней нет");
                Console.Read();
            }


        }


    }
}



