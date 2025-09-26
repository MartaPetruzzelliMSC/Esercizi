using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Dottore: Impiegato, IAzioniDottore, IPersonaleSanitario
    {
        public Dottore(string nome, string cognome, DateOnly dataDiNascita, string codiceFiscale, int id, decimal salario, 
            Reparto reparto, string specializzazione) : base(nome, cognome, dataDiNascita, codiceFiscale, id, salario)
        {
            RepartoAssegnato = reparto;

            Specializzazione = specializzazione;
        }

        public Reparto RepartoAssegnato { get; private set; }
        
        public string Specializzazione { get; private set; }

        public override void GetOverViewData()
        {
            Console.WriteLine($"Dr. {base.GetOverViewData} | Reparto: {RepartoAssegnato} | Specializzazione: {Specializzazione}");
        }

        //public bool PuoModificareReparto(Paziente paziente)
        //{
        //    if(RepartoAssegnato == paziente.RepartoAttuale)
        //    {
        //        return true;
        //    }
        //    return false;
        //}

        //public void PrescriveOModificaCura(Paziente paziente, CartellaClinica cartella, TimeOnly tempo, string medicina)
        //{
        //    if(cartella.IdPaziente == paziente.IdPaziente)
        //    {
        //        cartella.TerapiaGiornaliera[tempo] = medicina;
        //    }
           
        //}

        //public void SpostaPaziente(Paziente paziente, Reparto reparto)
        //{
        //    if(PuoModificareReparto(paziente))
        //    {
        //        paziente.ModificaReparto(this, reparto);
        //    }
        //}

        //public void SomministraCura(Paziente paziente, CartellaClinica cartella, DateTime orario, string medicina)
        //{
        //    if (cartella.IdPaziente == paziente.IdPaziente)
        //    {
        //        cartella.RegistroSomministrazioni[orario] = medicina;
        //    }
        //}

        //public void CambiaStatusPaziente(Paziente paziente, CartellaClinica cartella, StatoPaziente status)
        //{
        //    if (cartella.IdPaziente == paziente.IdPaziente)
        //    {
        //        cartella.Status = status;
        //    }
        //}

    }

}
