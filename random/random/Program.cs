using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace slumptal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // följande tar in data från cmd
            Console.WriteLine("Ange antalet tärningar: ");
            int antalTarningar = int.Parse(Console.ReadLine());
            Console.WriteLine("Ange antalet kastningar: ");
            int antalForsok = int.Parse(Console.ReadLine());

            Console.WriteLine("Ska det kolla efter summan? (ja/nej)");
            string checkSum = Console.ReadLine();

            int ett = 0;
            int tva = 0;
            int tre = 0;
            int fyra = 0;
            int fem = 0;
            int sex = 0;

            string minOrExact;
            int desiredSum = 0;
            if (checkSum == "nej")
            {
                Console.WriteLine("Ange antalet ettor som önskas: ");
                ett = int.Parse(Console.ReadLine());
                Console.WriteLine("Ange antalet tvåor som önskas: ");
                tva = int.Parse(Console.ReadLine());
                Console.WriteLine("Ange antalet treor som önskas: ");
                tre = int.Parse(Console.ReadLine());
                Console.WriteLine("Ange antalet fyror som önskas: ");
                fyra = int.Parse(Console.ReadLine());
                Console.WriteLine("Ange antalet femor som önskas: ");
                fem = int.Parse(Console.ReadLine());
                Console.WriteLine("Ange antalet sexor som önskas: ");
                sex = int.Parse(Console.ReadLine());

                Console.WriteLine("Ska det vara minst eller exact denna antalet? (minst/exact)");
                minOrExact = Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Vad för summan?");
                desiredSum = int.Parse(Console.ReadLine());

                minOrExact = "a";
            }


            simulation simulation = new simulation();// skapa objekten "simulation"
            // kasta tärningen och bärekna sannolikhet
            double prob = simulation.BeraknaSannolikhet(antalTarningar, antalForsok, minOrExact, checkSum, desiredSum, ett, tva, tre, fyra, fem, sex);
            Console.WriteLine($"Sannolikheten är: {prob:P2}");// skriva ut sannolikheten
            // {prob:P2} <-- P betyder att omvandla till procent, 2 betyder att avrunda till 2 decimaler
        }
    }
}