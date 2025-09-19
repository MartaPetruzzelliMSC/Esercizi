// See https://aka.ms/new-console-template for more information
using Logic.Test;
using Logic.Test.Object;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

int capitolo = 4;
TestaCapitolo(capitolo);


void TestaCapitolo(int capitolo, bool eseguiTutto = false)
{
    switch (capitolo)
    {
        case 0:

            var listaDiTest = new SalarioTestInputOutput[]
            {
            new SalarioTestInputOutput(new int[] { 1, 0, 0, 0}, -52.500M),
            new SalarioTestInputOutput(new int[] { 1, 1, 1, 1}, 48.000M),
            new SalarioTestInputOutput(new int[] { 1, 8, 8, 0, 0}, 149.500M),
            new SalarioTestInputOutput(new int[] { 0, 10, 10, 0}, 216.000M),
            new SalarioTestInputOutput(new int[] { 1, 0, 1, 0}, -22.000M),
            new SalarioTestInputOutput(new int[] { 1, 1, 1, 1, 1, 1, 1}, 1458.500M),
            };

            var testaSalario = new TestSalario();
            testaSalario.Testa(listaDiTest.ToList());
            break;

        case 1:

            TestControlloAccesso testControlloAccesso = new TestControlloAccesso();
            testControlloAccesso.Testa();
            break;

        case 2:

            TestArray testArray = new TestArray();
            testArray.Testa();
            break;

        case 3:

            TestStringhe testStringhe = new TestStringhe();
            testStringhe.Testa(includiLivelloDifficile: true);
            break;

        case 4:

            TestAltriAlgoritmi testAltriAlgoritmi = new TestAltriAlgoritmi();
            testAltriAlgoritmi.Testa();
            break;

        default:
            if (eseguiTutto)
                Console.WriteLine("Fine capitoli.");
            else
                Console.WriteLine("Inserisci un numero di capitolo valido");
            return;
    }

    if (eseguiTutto)
    {
        TestaCapitolo(capitolo + 1, true);
    }
}







