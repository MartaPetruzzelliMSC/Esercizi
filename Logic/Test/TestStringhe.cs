using Logic.Core.Esercizi;
using Logic.Test.Utilita;

namespace Logic.Test
{
    public class TestStringhe : TestBase
    {
        public void Testa(bool includiLivelloDifficile = false)
        {
            DisplayHelper.MostraTitolo("Exercises on Strings");

            string sorgente = "Ciao, questo è un esempio di stringa.";
            EseguiTest(sorgente);
            sorgente = "Benvenuto, questo, è a casa mia";
            EseguiTest(sorgente);

            if (includiLivelloDifficile)
            {
                var x = "ciao ciao proviamo come funziona proviamo";
                TestaLivelloDifficile(x);
            }

            DisplayHelper.MostraRisultati("Exercises on Strings", numeroDiTestEffettuati, numeroDiTestCorretti);
        }

        public void EseguiTest(string sorgente)
        {
            //// Esercizio
            EseguiEAggiornaStatistiche("Contiene", (s, p) => StringHelper.Contiene(s, p), (s, p) => s.Contains(p), sorgente, "esempio");
            EseguiEAggiornaStatistiche("Contiene", (s, p) => StringHelper.Contiene(s, p), (s, p) => s.Contains(p), sorgente, "casa");
            EseguiEAggiornaStatistiche("Contiene", (s, p) => StringHelper.Contiene(s, p), (s, p) => s.Contains(p), sorgente, "quest");
            EseguiEAggiornaStatistiche("Contiene", (s, p) => StringHelper.Contiene(s, p), (s, p) => s.Contains(p), sorgente, "è");
            EseguiEAggiornaStatistiche("Contiene", (s, p) => StringHelper.Contiene(s, p), (s, p) => s.Contains(p), sorgente, "ca");

            //// Esercizio
            EseguiEAggiornaStatistiche("TrovaPosizioneDi", (s, p) => StringHelper.TrovaPosizioneDi(s, p), (s, p) => s.IndexOf(p), sorgente, 'C');
            EseguiEAggiornaStatistiche("TrovaPosizioneDi", (s, p) => StringHelper.TrovaPosizioneDi(s, p), (s, p) => s.IndexOf(p), sorgente, 'q');
            EseguiEAggiornaStatistiche("TrovaPosizioneDi", (s, p) => StringHelper.TrovaPosizioneDi(s, p), (s, p) => s.IndexOf(p), sorgente, 'e');
            EseguiEAggiornaStatistiche("TrovaPosizioneDi", (s, p) => StringHelper.TrovaPosizioneDi(s, p), (s, p) => s.IndexOf(p), sorgente, 'u');

            //// Esercizio
            EseguiEAggiornaStatistiche("IndiceDi", (s, p) => StringHelper.TrovaInizioDi(s, p), (s, p) => s.IndexOf(p), sorgente, "esempio");
            EseguiEAggiornaStatistiche("IndiceDi", (s, p) => StringHelper.TrovaInizioDi(s, p), (s, p) => s.IndexOf(p), sorgente, "Ciao");
            EseguiEAggiornaStatistiche("IndiceDi", (s, p) => StringHelper.TrovaInizioDi(s, p), (s, p) => s.IndexOf(p), sorgente, "questo");
            EseguiEAggiornaStatistiche("IndiceDi", (s, p) => StringHelper.TrovaInizioDi(s, p), (s, p) => s.IndexOf(p), sorgente, "casa");
            EseguiEAggiornaStatistiche("IndiceDi", (s, p) => StringHelper.TrovaInizioDi(s, p), (s, p) => s.IndexOf(p), sorgente, "stringa.");
            EseguiEAggiornaStatistiche("IndiceDi", (s, p) => StringHelper.TrovaInizioDi(s, p), (s, p) => s.IndexOf(p), sorgente, "questo,");

            //// Esercizio
            EseguiEAggiornaStatistiche("IniziaCon", (s, p) => StringHelper.IniziaCon(s, p), (s, p) => s.StartsWith(p), sorgente, "Ciao");
            EseguiEAggiornaStatistiche("IniziaCon", (s, p) => StringHelper.IniziaCon(s, p), (s, p) => s.StartsWith(p), sorgente, "Ciao,");
            EseguiEAggiornaStatistiche("IniziaCon", (s, p) => StringHelper.IniziaCon(s, p), (s, p) => s.StartsWith(p), sorgente, "questo");
            EseguiEAggiornaStatistiche("IniziaCon", (s, p) => StringHelper.IniziaCon(s, p), (s, p) => s.StartsWith(p), sorgente, "casa");
            EseguiEAggiornaStatistiche("IniziaCon", (s, p) => StringHelper.IniziaCon(s, p), (s, p) => s.StartsWith(p), sorgente, "ciao");

            //// Esercizio
            EseguiEAggiornaStatistiche("RimpiazzaSemplice", (s, p, q) => StringHelper.RimpiazzaSemplice(s, p, q), (s, p, q) => s.Replace(p, q), sorgente, "Ciao", "Helo");
            EseguiEAggiornaStatistiche("RimpiazzaSemplice", (s, p, q) => StringHelper.RimpiazzaSemplice(s, p, q), (s, p, q) => s.Replace(p, q), sorgente, "esempio", "example");
            EseguiEAggiornaStatistiche("RimpiazzaSemplice", (s, p, q) => StringHelper.RimpiazzaSemplice(s, p, q), (s, p, q) => s.Replace(p, q), sorgente, "di", "of");
            EseguiEAggiornaStatistiche("RimpiazzaSemplice", (s, p, q) => StringHelper.RimpiazzaSemplice(s, p, q), (s, p, q) => s.Replace(p, q), sorgente, "è", "e");

            try
            {
                StringHelper.RimpiazzaSemplice(sorgente, "questo", "that one");
                Console.WriteLine("Rimpiazza, eccezione quando parole di diversa lunghezza - FAILED");
                CompareValues(1 == 0);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Rimpiazza, eccezione quando parole di diversa lunghezza - PASSED");
                CompareValues(1 == 1);
            }
        }

        public void TestaLivelloDifficile(string sorgente)
        {
            EseguiEAggiornaStatistiche("Rimpiazza", (s, p, q) => StringHelper.Rimpiazza(s, p, q), (s, p, q) => s.Replace(p, q), sorgente, "proviamo", "vediamo");
            EseguiEAggiornaStatistiche("Rimpiazza", (s, p, q) => StringHelper.Rimpiazza(s, p, q), (s, p, q) => s.Replace(p, q), sorgente, "ciao", "buongiorno");
            EseguiEAggiornaStatistiche("Rimpiazza", (s, p, q) => StringHelper.Rimpiazza(s, p, q), (s, p, q) => s.Replace(p, q), sorgente, "come", "");
            EseguiEAggiornaStatistiche("Rimpiazza", (s, p, q) => StringHelper.Rimpiazza(s, p, q), (s, p, q) => s.Replace(p, q), sorgente, "come", "");
            EseguiEAggiornaStatistiche("Rimpiazza", (s, p, q) => StringHelper.Rimpiazza(s, p, q), (s, p, q) => s.Replace(p, q), sorgente, ",", ".");
        }


    }
}
