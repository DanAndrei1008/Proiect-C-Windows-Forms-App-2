using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BazaDateSpital
{
    public class Persoana
    {
        public int Id { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public char Sex { get; set; }
        public int Varsta { get; set; }
        public string DataNastere { get; set; }
        public string CNP { get; set; }


        public Persoana(int id, string nume, string prenume, char sex, int varsta, string dataNastere, string cnp)
        {
            Id = id;
            Nume = nume;
            Prenume = prenume;
            Sex = sex;
            Varsta = varsta;
            DataNastere = dataNastere;
            CNP = cnp;
        }
      
        //public override string ToString()
        //{
        //    return $"Persoana cu numele {Nume} {Prenume} , sex {Sex}, nascut/a in {DataNastere} cu varsta de {Varsta} ani.";
        //}






    }
   


}
