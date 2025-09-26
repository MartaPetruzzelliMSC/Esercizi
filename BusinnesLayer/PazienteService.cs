using DataAccessLayer;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class PazienteService
    {
        private Database db;

        public PazienteService(Database db)
        {
            this.db = db;
        }

        public void ModificaReparto(IAzioniDottore dottore, Reparto reparto, Paziente paziente)
        {
            if (dottore != null && dottore.PuoModificareReparto(paziente, dottore))
            {
                paziente.RepartoAttuale = reparto;
            }
        }
    }
}
