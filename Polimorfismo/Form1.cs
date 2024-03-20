using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Polimorfismo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Las dos lineas verticales || indican el operador OR logico y && el operador Y logico
            if (textBox2.Text == string.Empty || textBox3.Text == string.Empty || textBox4.Text == string.Empty)
            {
                MessageBox.Show("Ingresa los datos faltantes");
            }
            else
            {
                double b = double.Parse(textBox3.Text);
                double a = double.Parse(textBox4.Text);
                double r = double.Parse(textBox9.Text);

                carroseria carroc = new carroseria(textBox2.Text, b, a);
                llantas llanta1 = new llantas (textBox5.Text, r);
                llantas llanta2 = new llantas (textBox6.Text, r);
                llantas llanta3 = new llantas (textBox7.Text, r);
                llantas llanta4 = new llantas (textBox8.Text, r);

                textBox1.Text = carroc.MostrarArea();
                textBox1.Text += llanta1.MostrarDiametro();
                textBox1.Text += llanta2.MostrarDiametro();
                textBox1.Text += llanta3.MostrarDiametro();
                textBox1.Text += llanta4.MostrarDiametro();
            }
        }
    }
}
