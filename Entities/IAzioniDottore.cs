using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public interface IAzioniDottore
    {
        void PrescriveOModificaCura(Paziente paziente, CartellaClinica cartella, TimeOnly tempo, string medicina);

        void SpostaPaziente(Paziente paziente, Reparto reparto, Dottore dottore);

        bool PuoModificareReparto(Paziente paziente, IAzioniDottore dottore);

        void CambiaStatusPaziente(Paziente paziente, CartellaClinica cartella, StatoPaziente status);
    }
}
