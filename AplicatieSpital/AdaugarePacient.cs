using BazaDateSpital;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicatieSpital
{
    public partial class AdaugarePacient : Form
    {
        public AdaugarePacient()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pacient p1 = new Pacient(Convert.ToInt32(textBox1.Text), textBox2.Text, textBox3.Text, Convert.ToChar(textBox4.Text), Convert.ToInt32(textBox5.Text), textBox6.Text, textBox7.Text, textBox10.Text, textBox11.Text, textBox12.Text, textBox13.Text, Convert.ToBoolean(textBox14.Text), Convert.ToBoolean(textBox15.Text), textBox16.Text);
            listBox1.Items.Add("Id" + p1.Id);
            listBox1.Items.Add("Nume" + p1.Nume);
            listBox1.Items.Add("Prenume" + p1.Nume);
            listBox1.Items.Add("Cauza internarii" + p1.CauzaInternare);

            var form = Application.OpenForms.OfType<Form1>().FirstOrDefault();
            form.AddPacienti(p1);


            var lines = File.ReadAllLines("Decedati.txt").Length;
            List<string> loglist = File.ReadAllLines("Decedati.txt").ToList();
            if (textBox14.Text == "true")
            {
                File.AppendAllText("Decedati.txt", label14.Text + ":" + textBox2.Text + " " + textBox3.Text + "\r\n");
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Pacient p1 = new Pacient(Convert.ToInt32(textBox1.Text), textBox2.Text, textBox3.Text, Convert.ToChar(textBox4.Text), Convert.ToInt32(textBox5.Text), textBox6.Text, textBox7.Text, textBox10.Text, textBox11.Text, textBox12.Text, textBox13.Text, Convert.ToBoolean(textBox14.Text), Convert.ToBoolean(textBox15.Text), textBox16.Text);
            listBox1.Items.Remove("Id" + p1.Id);
            listBox1.Items.Remove("Nume" + p1.Nume);
            listBox1.Items.Remove("Prenume" + p1.Nume);
            listBox1.Items.Remove("Cauza internarii" + p1.CauzaInternare);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StreamWriter Matchlog = File.CreateText("Decedati.txt");
            Matchlog.Flush();
            Matchlog.Close();
            listBox1.Items.Clear();
        }
    }
}
