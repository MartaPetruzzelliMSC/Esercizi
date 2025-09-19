using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Test.Object
{
    public class SalarioTestInputOutput
    {
        public int[] OreGiornaliere { get; }

        public decimal Salario { get; private set; }

        public SalarioTestInputOutput(int[] oreLavorate, decimal salarioAspettato)
        {
            OreGiornaliere = oreLavorate;
            Salario = salarioAspettato;
        }
    }
}
