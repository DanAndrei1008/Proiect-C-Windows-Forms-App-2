using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BazaDateSpital
{
    public abstract class PersonalAdiacent:Angajat
    {
        
        public PersonalAdiacent(int id, string nume, string prenume, char sex, int varsta, string dataNastere, string cnp, string post, string program, string salariu, string studii, string sectie) : base(id, nume, prenume, sex, varsta, dataNastere, cnp,post, program, salariu, studii, sectie)
        {
            
        }
    }
}
