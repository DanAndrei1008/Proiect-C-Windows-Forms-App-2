using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BazaDateSpital
{
    class Doctor: Angajat, IPacient
    {
       
        public string Specializare { get; set; }
        public List<Pacient> Pacienti;

        public Doctor(int id, string nume, string prenume, char sex, int varsta, string dataNastere, string cnp, string post, string program, string salariu, string studii,string specializare, string sectie) : base(id, nume, prenume, sex, varsta, dataNastere, cnp, post, program, salariu, studii, sectie )
        {
            Specializare = specializare;
            Pacienti = new List<Pacient>();
        }

        public void AddPacient(Pacient pacient)
        {
            Pacienti.Add(pacient);
        }

        public void RemovePacient(Pacient pacient)
        {
            Pacienti.Remove(pacient);
        }

    }

}
