using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Core.Array
{
    public static class ArrayHelper
    {
        public static int Conta(int[] collezione)
        {
            int counter = 0;
            foreach(int i in collezione)
            {
                counter++;
            }
            return counter;
        }

        public static bool Cerca(int[] collezione, int obiettivo)
        {
            bool isPresent = false;
            foreach(int i in collezione)
            {
                if(i == obiettivo)
                {
                    isPresent = true;
                }
            }
            return isPresent;
        }

        public static int CercaValoreMinimo(int[] collezione)
        {
            int min = collezione[0];
            for(int i = 0; i < Conta(collezione); i++)
            {
                if (collezione[i] < min)
                {
                    min = collezione[i];
                }
            }
            return min;
        }

        public static int CercaValoreMassimo(int[] collezione, int estremoSuperiore = int.MaxValue)
        {
            int max = collezione[0];
            for (int i = 0; i < Conta(collezione); i++)
            {
                if (collezione[i] > max)
                {
                    max = collezione[i];
                }
            }
            return max;
        }

        public static int Somma(int[] collezione)
        {
            int sum = 0;
            for(int i = 0; i < Conta(collezione); i++)
            {
                sum += collezione[i];
            }
            return sum;
        }

        public static double CalcolaMedia(int[] collezione)
        {
            return (double)Somma(collezione) / Conta(collezione);
        }

        public static int ContaIntervallo(int[] collezione, int minimo, int massimo)
        {
            int counter = 0;
            for(int i = 0; i < Conta(collezione); i++)
            {
                if (collezione[i] >= minimo && collezione[i] <= massimo)
                {
                    counter++;
                }
            }
            return counter;
        }

        public static int ContaSe(int[] collezione, int opzione)
        {
            int intervallo;
            if(opzione == 1)
            {
                intervallo = ContaIntervallo(collezione, 1, int.MaxValue);
            }
            else if(opzione == 0)
            {
                intervallo = ContaIntervallo(collezione, 0, 0);
            }
            else if(opzione == -1)
            {
                intervallo = ContaIntervallo(collezione, int.MinValue, -1);
            }
            else
            {
                throw new ArgumentException("Opzione non valida"); 
            }
            return intervallo;
        }
    }
}
