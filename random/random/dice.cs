using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace slumptal
{
    internal class dice
    {
        private Random rng = new Random();
        public int Kasta()
        {
            return rng.Next(1, 7);//kasta tärningen
        }
    }
}