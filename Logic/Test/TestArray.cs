using Logic.Core.Array;
using Logic.Core.Esercizi;
using Logic.Test.Utilita;

namespace Logic.Test
{
    public class TestArray : TestBase
    {
        public void Testa() 
        {
            DisplayHelper.MostraTitolo("Esercizi sugli array");
            int[] vettore = new int[]{ 1, 2, 4, 5, 6, 7, 8, 9, 10, };
            EseguiTest(vettore);
            vettore = new int[] { 0 };
            EseguiTest(vettore);
            vettore = new int[] { 10, 11, 12, 13 };
            EseguiTest(vettore);
            vettore= Enumerable.Range(0, 10000).ToArray();
            EseguiTest(vettore);

            DisplayHelper.MostraRisultati("Esercizi sugli array", numeroDiTestEffettuati, numeroDiTestCorretti);
        }

        public void EseguiTest(int[] vettore)
        {
            EseguiEAggiornaStatistiche("Conta", v => ArrayHelper.Conta(v), v => v.Length, vettore);

            EseguiEAggiornaStatistiche("Cerca", (v,p) => ArrayHelper.Cerca(v,p), (v,p) => v.Any(x => x == p), vettore, 4);
            EseguiEAggiornaStatistiche("Cerca", (v, p) => ArrayHelper.Cerca(v, p), (v, p) => v.Any(x => x == p), vettore, 0);
            EseguiEAggiornaStatistiche("Cerca", (v, p) => ArrayHelper.Cerca(v, p), (v, p) => v.Any(x => x == p), vettore, 10);
            EseguiEAggiornaStatistiche("Cerca", (v, p) => ArrayHelper.Cerca(v, p), (v, p) => v.Any(x => x == p), vettore, 100);


            EseguiEAggiornaStatistiche("Minimo", (v) => ArrayHelper.CercaValoreMinimo(v), (v) => v.Min(), vettore);
            EseguiEAggiornaStatistiche("Max", (v) => ArrayHelper.CercaValoreMassimo(v), (v) => v.Max(), vettore);
            EseguiEAggiornaStatistiche("Sum", (v) => ArrayHelper.Somma(v), (v) => v.Sum(), vettore);
            EseguiEAggiornaStatistiche("Average", (v) => ArrayHelper.CalcolaMedia(v), (v) => v.Average(), vettore);

            EseguiEAggiornaStatistiche("Intervallo", (v, p1, p2) => ArrayHelper.ContaIntervallo(v, p1, p2), (v, p1, p2) => v.Count(x => x >= p1 && x <= p2), vettore, 1, 10);
            EseguiEAggiornaStatistiche("Intervallo", (v, p1, p2) => ArrayHelper.ContaIntervallo(v, p1, p2), (v, p1, p2) => v.Count(x => x >= p1 && x <= p2), vettore, 11, 15);
            EseguiEAggiornaStatistiche("Intervallo", (v, p1, p2) => ArrayHelper.ContaIntervallo(v, p1, p2), (v, p1, p2) => v.Count(x => x >= p1 && x <= p2), vettore, 2, 4);
            EseguiEAggiornaStatistiche("Intervallo", (v, p1, p2) => ArrayHelper.ContaIntervallo(v, p1, p2), (v, p1, p2) => v.Count(x => x >= p1 && x <= p2), vettore, 98, 100);
            EseguiEAggiornaStatistiche("Intervallo", (v, p1, p2) => ArrayHelper.ContaIntervallo(v, p1, p2), (v, p1, p2) => v.Count(x => x >= p1 && x <= p2), vettore, -10, -1);


            EseguiEAggiornaStatistiche("ContaSe", (v, p) => ArrayHelper.ContaSe(v, p), (v, p) => v.Count(x => x == 0), vettore, 0);
            EseguiEAggiornaStatistiche("ContaSe", (v, p) => ArrayHelper.ContaSe(v, p), (v, p) => v.Count(x => x > 0), vettore, 1);
            EseguiEAggiornaStatistiche("ContaSe", (v, p) => ArrayHelper.ContaSe(v, p), (v, p) => v.Count(x => x < 0), vettore, -1);
        }
    }
}
