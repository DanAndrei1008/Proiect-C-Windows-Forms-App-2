using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BazaDateSpital
{
    public interface IPacient
    {
        public void AddPacient(Pacient pacient);
        public void RemovePacient(Pacient pacient);
    }
}
