using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public abstract class Impiegato : Person
    {

        public int IdDipendente { get; private set; }
        public decimal Salario { get; private set; }

        protected Impiegato(string nome, string cognome, DateOnly dataDiNascita, string codiceFiscale, int id, decimal salario) : 
            base(nome, cognome, dataDiNascita, codiceFiscale)
        {
            IdDipendente = id;
            Salario = salario;

        }

        public override void GetOverViewData()
        {
            base.GetOverViewData();
        }

    }
}
