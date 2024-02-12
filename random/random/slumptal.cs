using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace slumptal
{
    internal class simulation
    {
        public double BeraknaSannolikhet(int antalTarningar, int antalForsok, string minOrExact, string checkSum, int desiredSum, int onskadeEttor, int onskadeTvaor, int onskadeTreor, int onskadeFyror, int onskadeFemor, int onskadeSexor)
        {
            dice tarning = new dice();// skapa objekt tärning
            int lyckadeForsok = 0;// spara lyckade försök for sannolikheten
            int[] diceList = new int[antalTarningar];
            int sum = 0;

            for (int i = 0; i < antalForsok; i++)// antal gångar att kasta
            {
                int ett = 0;
                int tva = 0;
                int tre = 0;
                int fyra = 0;
                int fem = 0;
                int sex = 0;

                for (int j = 0; j < antalTarningar; j++)// antal tärningar att kasta
                {
                    int result = tarning.Kasta();// kasta tärning
                    // spara värderna av kastningar

                    if (checkSum == "nej")
                    {
                        if (result == 1) ett++;
                        if (result == 2) tva++;
                        if (result == 3) tre++;
                        if (result == 4) fyra++;
                        if (result == 5) fem++;
                        if (result == 6) sex++;
                    }
                    else
                    {
                        diceList[j] = result;
                    }
                }
                if (checkSum == "ja")
                {
                    foreach (int num in diceList)
                    {
                        sum += num;
                    }
                    if (sum >= desiredSum)
                    {
                        lyckadeForsok++;
                    }
                }
                Array.Clear(diceList, 0, diceList.Length);
                sum = 0;

                // om alla värderna passar det man ville då lägga till 1 till lyckadeForsok
                if (minOrExact == "minst")
                {// om minst
                    if (ett >= onskadeEttor
                     && tva >= onskadeTvaor
                     && tre >= onskadeTreor
                     && fyra >= onskadeFyror
                     && fem >= onskadeFemor
                     && sex >= onskadeSexor)
                    {
                        lyckadeForsok++;
                    }
                }
                else if (minOrExact == "exact")// annars exact
                {

                    if ((onskadeEttor == 0 || ett == onskadeEttor)
                     && (onskadeTvaor == 0 || tva == onskadeTvaor)
                     && (onskadeTreor == 0 || tre == onskadeTreor)
                     && (onskadeFyror == 0 || fyra == onskadeFyror)
                     && (onskadeFemor == 0 || fem == onskadeFemor)
                     && (onskadeSexor == 0 || sex == onskadeSexor))
                    {
                        lyckadeForsok++;
                    }
                }
            }
            // bärekna sannolikhet genom att dela antalet det man ville få med antalet kastningar
            return (double)lyckadeForsok / antalForsok;
        }
    }
}