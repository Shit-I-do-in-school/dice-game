using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            calc cal = new calc();
            bool kör = true;
            while (kör) { 
                Console.WriteLine("Skriv plusa för att plusa");
                Console.WriteLine("Skriv minusa för att minusa");
                Console.WriteLine("Skriv gångra för att gångra");
                Console.WriteLine("Skriv dela för att dela");
                Console.WriteLine("Skriv E för att stänga av");
                string input = Console.ReadLine().ToLower();

                if (input == "e")
                {
                    kör = false;
                }
                else
                try {
                Console.WriteLine("Tal 1: ");
                double tal1 = Double.Parse(Console.ReadLine());
                Console.WriteLine("Tal 2: ");
                double tal2 = Double.Parse(Console.ReadLine());

                if (input == "plusa") {
                    Console.WriteLine($"summan av talen = " + cal.plusa(tal1, tal2));
                } 
                else if (input == "minusa")  {
                    Console.WriteLine($"summan av talen = " + cal.minus(tal1, tal2));
                }
                else if (input == "gångra")  {
                    Console.WriteLine($"summan av talen = " + cal.gånger(tal1, tal2));
                }
                else if (input == "dela")  {
                    Console.WriteLine($"summan av talen = " + cal.dela(tal1, tal2));
                }
                }
                catch (Exception e)
                    {
                        Console.WriteLine("SKRIV EN SIFFRA INTE EN BOKSTAV tack :)");
                    }
            }
        }
    }
}
