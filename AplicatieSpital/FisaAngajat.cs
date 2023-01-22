using BazaDateSpital;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicatieSpital
{
    public partial class FisaAngajat : Form
    {
        private Form1 form;
        private List<Angajat> Angajati;

        

        public FisaAngajat()
        {
            Angajati = Application.OpenForms.OfType<Form1>().FirstOrDefault().GetAngajati();
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            var AngajatID = Convert.ToInt32(textBox1.Text);
            foreach(Angajat angajat in Angajati)
            {
                if(AngajatID == angajat.Id)
                {
                    listBox1.Items.Add("Id: " + angajat.Id);
                    listBox1.Items.Add("Nume: " + angajat.Nume);
                    listBox1.Items.Add("Prenume: " + angajat.Prenume);
                    listBox1.Items.Add("Sex: " + angajat.Sex);
                    listBox1.Items.Add("Varsta: " + angajat.Varsta);
                    listBox1.Items.Add("DataNastere: " + angajat.DataNastere);
                    listBox1.Items.Add("CNP: " + angajat.CNP);
                    listBox1.Items.Add("Post: " + angajat.Post);
                    listBox1.Items.Add("Program: " + angajat.Program);
                    listBox1.Items.Add("Salariu: " + angajat.Salariu);
                    listBox1.Items.Add("Studii: " + angajat.Studii);
                    listBox1.Items.Add("Sectie: " + angajat.Studii);
                }
            }



        }
    }
}
