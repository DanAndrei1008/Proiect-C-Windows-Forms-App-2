using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BazaDateSpital;

namespace AplicatieSpital
{
    public partial class Form1 : Form
    {
        private List<Angajat> Angajati;
        private List<Pacient> Pacienti;
        public Form1()
        {
            Angajati = new List<Angajat>();
            Pacienti = new List<Pacient>();
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public void AddAngajati(Angajat angajat)
        {
            Angajati.Add(angajat);

        }

        public List<Angajat> GetAngajati()
        {
            return Angajati;
        }

        public void AddPacienti(Pacient pacient)
        {
            Pacienti.Add(pacient);
        }

        public List<Pacient> GetPacienti()
        {
            return Pacienti;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdaugarePacient f = new AdaugarePacient();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdaugareAngajat f = new AdaugareAngajat();
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PacientFisa f = new PacientFisa();
            f.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FisaAngajat f = new FisaAngajat();
            f.Show();
        }
    }
}
