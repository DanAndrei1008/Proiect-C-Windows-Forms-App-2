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
    public partial class AdaugareAngajat : Form
    {
        private Form1 form;

        public AdaugareAngajat()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Angajat a1 = new Angajat(Convert.ToInt32(textBox1.Text), textBox2.Text, textBox3.Text, Convert.ToChar(textBox4.Text), Convert.ToInt32(textBox5.Text), textBox6.Text, textBox7.Text, textBox8.Text,textBox9.Text, textBox10.Text, textBox11.Text, textBox12.Text);
            listBox1.Items.Add("Id" + a1.Id);
            listBox1.Items.Add("Nume" + a1.Nume);
            listBox1.Items.Add("Prenume" + a1.Prenume);
            listBox1.Items.Add("Post" + a1.Post);
            

            var form = Application.OpenForms.OfType<Form1>().FirstOrDefault();
            form.AddAngajati(a1); 
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Angajat a1 = new Angajat(Convert.ToInt32(textBox1.Text), textBox2.Text, textBox3.Text, Convert.ToChar(textBox4.Text), Convert.ToInt32(textBox5.Text), textBox6.Text, textBox7.Text, textBox8.Text, textBox9.Text, textBox10.Text, textBox11.Text, textBox12.Text);
            listBox1.Items.Remove("Id" + a1.Id);
            listBox1.Items.Remove("Nume" + a1.Nume);
            listBox1.Items.Remove("Prenume" + a1.Prenume);
            listBox1.Items.Remove("Post" + a1.Post);
            

            var lines = File.ReadAllLines("PersonalSters.txt").Length;
            List<string> loglist = File.ReadAllLines("PersonalSters.txt").ToList();
            
            File.AppendAllText("PersonalSters.txt", label8.Text + ":" + textBox8.Text + "," + textBox2.Text + " " + textBox3.Text +"\r\n");
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
