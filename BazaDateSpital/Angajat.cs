using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BazaDateSpital
{
    public class Angajat: Persoana
    {
        public string Post { get; set; }
        public string Program { get; set; }
        public string Salariu { get; set; }
        public string Studii { get; set; }
        public string Sectie { get; set; }

        public Angajat(int id, string nume, string prenume, char sex, int varsta, string dataNastere, string cnp, string post, string program, string salariu, string studii, string sectie) : base(id,nume,prenume,sex,varsta,dataNastere,cnp)
        {
            Post = post;
            Program = program;
            Salariu = salariu;
            Studii = studii;
            Sectie = sectie;

        }

        //public virtual string RedirectImpVenit(string destinatie)
        //{
        //    destinatie = "stat";
        //    return $"{CalculImpVenit} lei din impozitul de venit se duc catre {destinatie}";
        //}
        //public static int CalculImpVenit(double venit)
        //{
        //    return Convert.ToInt32(venit * 0.65 * 0.035);
        //}

    }
    
}
