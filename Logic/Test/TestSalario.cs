using Logic.Core.Salario;
using Logic.Test.Object;
using Logic.Test.Utilita;

namespace Logic.Test
{
    public class TestSalario : TestBase
    {
        public void Testa(List<SalarioTestInputOutput> listaDiTest)
        {
            DisplayHelper.MostraTitolo("Compute your salary");
            var pagaOraria = 10.0M;
            IndovinaIlSalario(listaDiTest, pagaOraria);
            DisplayHelper.MostraRisultati("Compute your salary", numeroDiTestEffettuati, numeroDiTestCorretti);
        }

        private void IndovinaIlSalario(List<SalarioTestInputOutput> listaDiTest, decimal pagaOraria)
        {
            foreach (var test in listaDiTest)
            {
                var oreComeStringa = "[" + string.Join(",", test.OreGiornaliere) + "]";
                EseguiEAggiornaStatistiche(oreComeStringa, ore => SalarioHelper.CalcolaSalario(ore, pagaOraria), s => test.Salario, test.OreGiornaliere);
            }
        }
    }
}
