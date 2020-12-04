using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITMO.WinForms.WinGrafSinLine6_1
{
    public class Operation
    {
        public static double SummSin(int x, double a, double b)
        {
            return Math.Sin(x * a) + Math.Sin(x * b);
        }
    }
}
