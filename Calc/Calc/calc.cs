using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
    internal class calc
    {
        public double plusa(double tal1, double tal2)
        {

            double plusar = tal1 + tal2;

            return plusar;
        }

        public double minus(double tal1, double tal2)
        {
            double minusar = tal1 - tal2;

            return minusar;
        }

        public double gånger(double tal1, double tal2)
        {
            double gångra = tal1 * tal2;
            return gångra;
        }

        public double dela(double tal1, double tal2)
        {
            double delar = tal1 / tal2;
            return delar;
        }

    
    }
}
