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

public partial class PacientFisa : Form
    {

        private Form1 form;
        private List<Pacient> Pacienti;



        public PacientFisa()
        {
            Pacienti = Application.OpenForms.OfType<Form1>().FirstOrDefault().GetPacienti();
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            var PacientID = Convert.ToInt32(textBox1.Text);
            foreach (Pacient pacient in Pacienti)
            {
                if (PacientID == pacient.Id)
                {
                    listBox1.Items.Add("Id: " + pacient.Id);
                    listBox1.Items.Add("Nume: " + pacient.Nume);
                    listBox1.Items.Add("Prenume: " + pacient.Prenume);
                    listBox1.Items.Add("Sex: " + pacient.Sex);
                    listBox1.Items.Add("Varsta: " + pacient.Varsta);
                    listBox1.Items.Add("Data nasterii: " + pacient.DataNastere);
                    listBox1.Items.Add("CNP: " + pacient.CNP);
                    listBox1.Items.Add("Cauza internarii: " + pacient.CauzaInternare);
                    listBox1.Items.Add("Starea la externare: " + pacient.StareExternare);
                    listBox1.Items.Add("Data externarii: " + pacient.DataExternare);
                    listBox1.Items.Add("Salon: " + pacient.Salon);


                }
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }
}
