using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITMO.WinForms.WindowsFormsChart6_3
{
    class dat
    {
        Random r;
        public dat()
        {
            r = new Random();
        }
        public dat(int t)
        {
            r = new Random(t);
        }
        public int random(int t)
        {
            return r.Next(t);
        }
    }
}
