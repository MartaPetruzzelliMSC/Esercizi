using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public interface IPersonaleSanitario
    {
        void SomministraCura(Paziente paziente, CartellaClinica cartella, DateTime orario, string medicina);
    }
}
