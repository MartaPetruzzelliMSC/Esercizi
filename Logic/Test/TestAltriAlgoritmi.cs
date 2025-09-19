using Logic.Core.Esercizi;
using Logic.Test.Utilita;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Test
{
    public class TestAltriAlgoritmi : TestBase
    {
        public void Testa()
        {
            DisplayHelper.MostraTitolo("More complex exercises");
            EseguiTest();
            DisplayHelper.MostraRisultati("More complex exercises", numeroDiTestEffettuati, numeroDiTestCorretti);
        }

        public void EseguiTest()
        {
            TestaPalindroma();
            TestaFibonacci();
            TestaEsploraArray();
            TestaConfrontaPrezzi();
        }

        private void TestaConfrontaPrezzi()
        {
            var supermercato1 = new int[] { 1, 2, 3, 4, 5, 6, 7, 9 };
            var supermercato2 = new int[] { 10, 7, 8, 9, 7, 11, 1, 1 };
            var result = supermercato1.ToList().ToArray();
            result[6] = result[7] = 1;
            
            EseguiEAggiornaStatistiche("ConfrontaPezzi", AltriAlgoritmiHelper.ControllaPezzi, (v, p) => result, supermercato1, supermercato2, (v1, v2) => v1.SequenceEqual(v2));

            EseguiEAggiornaStatistiche("CercaSecondoMassimo", AltriAlgoritmiHelper.CercaSecondoMassimo, (v) => 7, supermercato1);
            EseguiEAggiornaStatistiche("CercaSecondoMassimo", AltriAlgoritmiHelper.CercaSecondoMassimo, (v) => 10, supermercato2);
            EseguiEAggiornaStatistiche("CercaAltriMassimi", AltriAlgoritmiHelper.CercaMassimiSuccessivi, (v, p) => 6, supermercato1, 3);
            EseguiEAggiornaStatistiche("CercaAltriMassimi", AltriAlgoritmiHelper.CercaMassimiSuccessivi, (v, p) => 9, supermercato2, 3);

            var generatedExample = Enumerable.Range(0, 10000).ToArray(); // values [0 ,1, 2... ,9999]
            EseguiEAggiornaStatistiche("CercaAltriMassimi", AltriAlgoritmiHelper.CercaMassimiSuccessivi, (v, p) => 9999, generatedExample, 1);
            EseguiEAggiornaStatistiche("CercaAltriMassimi", AltriAlgoritmiHelper.CercaMassimiSuccessivi, (v, p) => 9998, generatedExample, 2);
            EseguiEAggiornaStatistiche("CercaAltriMassimi", AltriAlgoritmiHelper.CercaMassimiSuccessivi, (v, p) => 9997, generatedExample, 3);
            EseguiEAggiornaStatistiche("CercaAltriMassimi", AltriAlgoritmiHelper.CercaMassimiSuccessivi, (v, p) => 9990, generatedExample, 10);
            EseguiEAggiornaStatistiche("CercaAltriMassimi", AltriAlgoritmiHelper.CercaMassimiSuccessivi, (v, p) => 9900, generatedExample, 100);

            var supermercato3 = new decimal?[] { 1.5M, 2.5M, null, 4.5M, 6.5M, null };
            var supermercato4 = new decimal?[] { 10.1M, 7, 8.6M, 9, 7, 10, 1, 0.1M };
            var prezziMinimi = new decimal?[] { 1.5M, 2.5M, 8.6M, 4.5M, 6.5M, 10, 1, 0.1M };

            EseguiEAggiornaStatistiche("ConfrontaPezzi", AltriAlgoritmiHelper.ConfrontaPrezzi, (v, p) => prezziMinimi, supermercato3, supermercato4, (v1, v2) => v1.SequenceEqual(v2));

            var ingrossoD = new decimal[] { 512, 314, 654, 912 };
            var quantitaD = new decimal[] { 10, 10, 100, 1 };
            var scontoD = new decimal[] { 61.44M, 37.68M, 0, 1094.4M };
            EseguiEAggiornaStatistiche("CalcolaSconto", AltriAlgoritmiHelper.CalcolaSconto, (v, p, q) => scontoD, ingrossoD, quantitaD, 6.54M, (v1, v2) => v1.SequenceEqual(v2));

            EseguiEAggiornaStatistiche("Doube comparison", AltriAlgoritmiHelper.ValidaPunteggio, (d1, d2) => true, 0.7, 0.8);
            EseguiEAggiornaStatistiche("Double comparison", AltriAlgoritmiHelper.ValidaPunteggio, (d1, d2) => true, 0.2, 0.1);
            EseguiEAggiornaStatistiche("Double comparison", AltriAlgoritmiHelper.ValidaPunteggio, (d1, d2) => true, 0.1, 0.2);
            EseguiEAggiornaStatistiche("Doube comparison", AltriAlgoritmiHelper.ValidaPunteggio, (d1, d2) => false, 0.1, 0.1);
            EseguiEAggiornaStatistiche("Doube comparison", AltriAlgoritmiHelper.ValidaPunteggio, (d1, d2) => true, 0.9, 1.0);
        }

        private void TestaEsploraArray()
        {
            var array = new int[] { 1, 2, 10, 5, 6, 9, 100, 1 };
            EseguiEAggiornaStatistiche("EsploraArray", AltriAlgoritmiHelper.EsploraArray, (v, p) => -1, array, 10);
            EseguiEAggiornaStatistiche("EsploraArray", AltriAlgoritmiHelper.EsploraArray, (v, p) => -1, array, 10);
            EseguiEAggiornaStatistiche("EsploraArray", AltriAlgoritmiHelper.EsploraArray, (v, p) => -1, array, 132);
            EseguiEAggiornaStatistiche("EsploraArray", AltriAlgoritmiHelper.EsploraArray, (v, p) => 134, array, 1000);
  
            EseguiEAggiornaStatistiche("EsploraArrayContrario", AltriAlgoritmiHelper.EsploraArrayAlContrario, (v, p) => -1, array, 10);
            EseguiEAggiornaStatistiche("EsploraArrayContrario", AltriAlgoritmiHelper.EsploraArrayAlContrario, (v, p) => -1, array, 20);
            EseguiEAggiornaStatistiche("EsploraArrayContrario", AltriAlgoritmiHelper.EsploraArrayAlContrario, (v, p) => -1, array, 30);
            EseguiEAggiornaStatistiche("EsploraArrayContrario", AltriAlgoritmiHelper.EsploraArrayAlContrario, (v, p) => -1, array, 100);
            EseguiEAggiornaStatistiche("EsploraArrayContrario", AltriAlgoritmiHelper.EsploraArrayAlContrario, (v, p) => 134, array, 1000);
        }

        private void TestaPalindroma()
        {
            //// Esercizio
            string palindroma1 = "osso";
            string palindroma2 = "itopinonavevanonipoti";
            string palindroma3 = "amoroma";
            string palindroma4 = "Angolovarabologna";
            string palindroma5 = "casa";

            EseguiEAggiornaStatistiche("Palidromo", AltriAlgoritmiHelper.Palindroma, x => true, palindroma1);
            EseguiEAggiornaStatistiche("Palidromo", AltriAlgoritmiHelper.Palindroma, x => true, palindroma2);
            EseguiEAggiornaStatistiche("Palidromo", AltriAlgoritmiHelper.Palindroma, x => true, palindroma3);
            EseguiEAggiornaStatistiche("Palidromo", AltriAlgoritmiHelper.Palindroma, x => false, palindroma4);
            EseguiEAggiornaStatistiche("Palidromo", AltriAlgoritmiHelper.Palindroma, x => false, palindroma5);
        }

        private void TestaFibonacci()
        {
            EseguiEAggiornaStatistiche("Fibonacci", AltriAlgoritmiHelper.CalcolaNumeroFibonacci, x => 1, 0);
            EseguiEAggiornaStatistiche("Fibonacci", AltriAlgoritmiHelper.CalcolaNumeroFibonacci, x => 1, 1);
            EseguiEAggiornaStatistiche("Fibonacci", AltriAlgoritmiHelper.CalcolaNumeroFibonacci, x => 2, 2);
            EseguiEAggiornaStatistiche("Fibonacci", AltriAlgoritmiHelper.CalcolaNumeroFibonacci, x => 3, 3);
            EseguiEAggiornaStatistiche("Fibonacci", AltriAlgoritmiHelper.CalcolaNumeroFibonacci, x => 13, 6);
            EseguiEAggiornaStatistiche("Fibonacci", AltriAlgoritmiHelper.CalcolaNumeroFibonacci, x => 34, 8);
            EseguiEAggiornaStatistiche("Fibonacci", AltriAlgoritmiHelper.CalcolaNumeroFibonacci, x => 2584, 17);

            EseguiEAggiornaStatistiche("Lista_Fibonacci", AltriAlgoritmiHelper.CalcolaListaFibonacci, x => new[] { 1, 1, 2, 3, 5, 8, 13, 21, 34 }, 8, (v1, v2) => v1.SequenceEqual(v2));

        }


    }
}
