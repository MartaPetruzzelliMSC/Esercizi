using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Test.Utilita
{
    public class DisplayHelper
    {
        public static void MostraRisultati(string titolo, int testEffettuati, int testSuperati)
        {
            double percentualeDiSuccesso = testSuperati * 100 / testEffettuati;
            Console.WriteLine("\n\n-----------------------------------");
            Console.WriteLine(titolo);
            Console.WriteLine($"Test effettuati {testEffettuati}, test superati {testSuperati}");
            Console.WriteLine($"Percentuale di successo {percentualeDiSuccesso}%");
            Console.WriteLine("-----------------------------------\n\n");
        }

        public static void MostraTitolo(string titolo)
        {
            Console.WriteLine("\n\n-----------------------------------");
            Console.WriteLine(titolo);
            Console.WriteLine("-----------------------------------\n\n");
        }
    }
}
