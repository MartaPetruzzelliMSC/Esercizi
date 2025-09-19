using System.Collections.Concurrent;
using System.Linq.Expressions;
using System.Text;

namespace Logic.Core.Esercizi
{
    public class StringHelper
    {
        public static bool Contiene(string sorgente, string blocco)
        {
            for(int i = 0; i <= sorgente.Length - blocco.Length; i++)
            {
                if(sorgente.Substring(i, blocco.Length) == blocco)
                {
                    return true;
                }
            }
            return false;
        }

        public static int TrovaInizioDi(string sorgente, string blocco)
        {
            for (int i = 0; i <= sorgente.Length - blocco.Length; i++)
            {
                if (sorgente.Substring(i, blocco.Length) == blocco)
                {
                    return i;
                }
            }
            return -1;
        }

        public static bool IniziaCon(string sorgente, string blocco)
        {
            //string sottoStringa = sorgente.Substring(0, blocco.Length);
            //if (sottoStringa == blocco) return true;
            //return false;

            for(int i = 0; i < blocco.Length; i++)
            {
                if (sorgente[i] != blocco[i])
                {
                    return false;
                }
            }
            return true;
        }


        public static int TrovaPosizioneDi(string sorgente, char obiettivo)
        {
            for(int i = 0; i < sorgente.Length; i++)
            {
                if (sorgente[i] == obiettivo)
                {
                    return i;
                }
            }
            return -1;
        }

        public static string RimpiazzaSemplice(string sorgente, string blocco, string rimpiazzo)
        {
            if(blocco.Length != rimpiazzo.Length)
            {
                throw new ArgumentException("il rimpiazzo deve essere lungo quanto il blocco");
            }
            if(Contiene(sorgente, blocco))
            {
                int inizioBlocco = TrovaInizioDi(sorgente, blocco);
                return sorgente.Substring(0,inizioBlocco) + rimpiazzo + sorgente.Substring(inizioBlocco + rimpiazzo.Length);
            }
            return sorgente;
        }

        public static string Rimpiazza(string sorgente, string blocco, string rimpiazzo)
        {
            string replacement = sorgente;
            while(Contiene(replacement, blocco))
            {
                int inizioBlocco = TrovaInizioDi(replacement, blocco);
                replacement = replacement.Substring(0, inizioBlocco) + rimpiazzo + replacement.Substring(inizioBlocco + blocco.Length);
            }  
            return replacement;
        }
    }
}
