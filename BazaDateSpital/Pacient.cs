using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BazaDateSpital
{
    public class Pacient: Persoana
    {
        
        public string CauzaInternare { get; set; }
        public string DataInternare { get; set; }
        public string StareExternare { get; set; }
        public string DataExternare { get; set; }
        public bool Deces;
        public bool Externat;
        public string Salon { get; set; }
        

        public Pacient(int id, string nume, string prenume, char sex, int varsta, string dataNastere, string cnp, string cauzaInternare, string dataInternare, string satreExternare, string dataExternare, bool deces, bool externat, string salon) : base(id, nume, prenume, sex, varsta, dataNastere, cnp)
        {
            
            CauzaInternare = cauzaInternare;
            DataInternare = dataInternare;
            StareExternare = satreExternare;
            DataExternare = dataExternare;
            Deces = deces;
            Externat = externat;
            Salon = salon;
            

        }
    }
}
