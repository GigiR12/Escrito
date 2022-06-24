using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Escrito_Grafica
{
    public partial class Form1 : Form
    {
        ArrayList Lista = new ArrayList();

        public Form1()
        {
            
            InitializeComponent();
            
 

        }
            
        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            int cedu = Convert.ToInt32(textBox1.Text);
            int horas = Convert.ToInt32(textBox4.Text);
            int años = Convert.ToInt32(textBox5.Text);
            Class1.Amateur amateur = new Class1.Amateur(cedu,textBox2.Text,textBox3.Text,horas,años);
            Lista.Add(amateur.MostrarAmat());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int cedu = Convert.ToInt32(textBox6.Text);
            int horas = Convert.ToInt32(textBox9.Text);
            int sueldo = Convert.ToInt32(textBox10.Text);
            Class1.Profesional profesional = new Class1.Profesional(cedu, textBox7.Text, textBox8.Text, horas, sueldo);
            Lista.Add(profesional.MostrarProf());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int cedu = Convert.ToInt32(textBox1.Text);
            int horas = Convert.ToInt32(textBox4.Text);
            int años = Convert.ToInt32(textBox5.Text);
            Class1.Amateur amateur = new Class1.Amateur(cedu, textBox2.Text, textBox3.Text, horas, años);
            listBox1.Items.Add(amateur.MostrarAmat());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int cedu = Convert.ToInt32(textBox6.Text);
            int horas = Convert.ToInt32(textBox9.Text);
            int sueldo = Convert.ToInt32(textBox10.Text);
            Class1.Profesional profesional = new Class1.Profesional(cedu, textBox7.Text, textBox8.Text, horas, sueldo);
            listBox2.Items.Add(profesional.MostrarProf());
        }
    }
}
