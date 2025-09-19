using Logic.Core.Array;

namespace Logic.Core.Esercizi
{
    public class AltriAlgoritmiHelper
    {
        public static bool Palindroma(string sorgente)
        {
            for(int i = 0, j = sorgente.Length - 1; i < sorgente.Length / 2; i++, j--)
            {
                if (sorgente[i] != sorgente[j]) return false;
            }
            return true;
        }

        public static int CalcolaNumeroFibonacci(int interazioni)
        {
            return 0;
        }

        public static int[] CalcolaListaFibonacci(int numeroDiElementi)
        {
            return [0, 1];
        }

        public static int EsploraArray(int[] collezione, int maximumValue)
        {
            int sum = 0;
            for(int i = 0; i < collezione.Length; i++)
            {
                sum += collezione[i];
                if (sum >= maximumValue)
                {
                    return -1;
                }
            }
            return sum;
        }

        public static int EsploraArrayAlContrario(int[] collezione, int maximumValue)
        {
            int sum = 0;
            for (int i = collezione.Length-1; i >= 0; i--)
            {
                sum += collezione[i];
                if (sum >= maximumValue)
                {
                    return -1;
                }
            }
            return sum;
        }

        public static int[] ControllaPezzi(int[] supermercato1, int[] supermercato2)
        {
            int[] newArr = new int[supermercato1.Length];

            for(int i = 0; i < supermercato1.Length; i++)
            {
                newArr[i] = supermercato1[i] <= supermercato2[i] ? supermercato1[i] : supermercato2[i];
            }
            return newArr;
        }

        public static decimal?[] ConfrontaPrezzi(decimal?[] supermercato1, decimal?[] supermercato2)
        {
            return [0, 1];
        }

        public static decimal[] CalcolaSconto(decimal[] prezzoIngrosso, decimal[] quantita, decimal specialPrice)
        {
            return [0, 1];
        }

        public static bool ValidaPunteggio(double punteggioArray, double punteggioStringhe)
        {
            return false;
        }


        public static int CercaSecondoMassimo(int[] collezione)
            => CercaMassimiSuccessivi(collezione, 2);

        public static int CercaMassimiSuccessivi(int[] collezione, int iterations)
        {
            int counterIt = 0;
            int primoMax = int.MaxValue;
            int secondoMax = int.MinValue;
            while(counterIt < iterations)
            {
                for(int i = 0; i < collezione.Length; i++)
                {
                    if (collezione[i] < primoMax)
                    {
                        if (collezione[i] > secondoMax)
                        {
                            secondoMax = collezione[i];
                        }
                    }
                }
                primoMax = secondoMax;
                secondoMax = int.MinValue;
                counterIt++;    
            } 
            return primoMax;
        }
    }
}
