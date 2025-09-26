using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Infermiere: Impiegato, IPersonaleSanitario
    {
        public Reparto RepartoAssegnato;

        public Infermiere(Reparto repartoAssegnato, string nome, string cognome, 
            DateOnly dataDiNascita, string codiceFiscale, int id, decimal salario) : 
            base(nome, cognome, dataDiNascita, codiceFiscale, id, salario)
        {
            RepartoAssegnato = repartoAssegnato;
        }

        public void SomministraCura(Paziente paziente, CartellaClinica cartella, DateTime orario, string medicina)
        {
            if (cartella.IdPaziente == paziente.IdPaziente)
            {
                cartella.RegistroSomministrazioni[orario] = medicina;
            }
        }
    }
}
