using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class CartellaClinica
    {
        public CartellaClinica(SortedList<TimeOnly, string> terapiaGiornaliera, 
            SortedList<DateTime, string> registroSomministrazioni, string patologia, StatoPaziente status)
        {
            TerapiaGiornaliera = terapiaGiornaliera;
            RegistroSomministrazioni = registroSomministrazioni;
            Patologia = patologia;
            Status = status;
        }

        public SortedList<TimeOnly, string> TerapiaGiornaliera { get; set; }

        public SortedList<DateTime, string> RegistroSomministrazioni { get; set; }
        
        public string Patologia { get; private set; }

        public StatoPaziente Status { get; set; }

        public int IdPaziente { get; private set; }


    }

    public enum StatoPaziente
    {
        InCura,
        Dimesso,
        Deceduto
    }
}
