using DataAccessLayer;
using Entities;

namespace BusinnesLayer
{
    public class DoctorService : IAzioniDottore
    {
        private Database db;

        public DoctorService(Database db)
        {
            this.db = db;
        }

        public Dottore TrovaDottoreDaIdDipendente(int id)
        {
            foreach (var dottore in db.Dottori)
            {
                if (dottore.IdDipendente == id)
                {
                    return dottore;
                }
            }
            return null;
        }

        public Dottore CreaDottore(string nome, string cognome, DateOnly dataDiNascita, string codiceFiscale, int id, decimal salario,
            Reparto reparto, string specializzazione)
        {
            Dottore dottore = new Dottore(nome, cognome, dataDiNascita, codiceFiscale, id, salario, reparto, specializzazione);
            return dottore;
        }

        public bool PuoModificareReparto(Paziente paziente, Dottore dottore)
        {
            if (dottore.RepartoAssegnato == paziente.RepartoAttuale)
            {
                return true;
            }
            return false;
        }

        public void PrescriveOModificaCura(Paziente paziente, CartellaClinica cartella, TimeOnly tempo, string medicina)
        {
            if (cartella.IdPaziente == paziente.IdPaziente)
            {
                cartella.TerapiaGiornaliera[tempo] = medicina;
            }

        }

        public void SpostaPaziente(Paziente paziente, Reparto reparto, Dottore dottore)
        {
            if (PuoModificareReparto(paziente, dottore))
            {
                paziente.ModificaReparto(dottore, reparto);
            }
        }

        public void SomministraCura(Paziente paziente, CartellaClinica cartella, DateTime orario, string medicina)
        {
            if (cartella.IdPaziente == paziente.IdPaziente)
            {
                cartella.RegistroSomministrazioni[orario] = medicina;
            }
        }

        public void CambiaStatusPaziente(Paziente paziente, CartellaClinica cartella, StatoPaziente status)
        {
            if (cartella.IdPaziente == paziente.IdPaziente)
            {
                cartella.Status = status;
            }
        }
    }
}
