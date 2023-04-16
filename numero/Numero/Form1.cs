using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Numero
{
    public partial class Form1 : Form
    {
        Entero obj, objN2;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            obj = new Entero(0);
            objN2 = new Entero();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String entrada = textBox1.Text;
            obj.cargar(int.Parse(entrada));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String salida = String.Concat(obj.descargar());
            textBox2.Text = salida;
        }

        private void invertirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            obj.Invertir();
        }

        private void capicuaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox2.Text = Convert.ToString(obj.EsCapicua());
        }

        private void unirNUmDerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            obj.UnirNumDerecha(int.Parse(textBox1.Text));
        }

        private void unir2NumASCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            obj.Unir2numAsc(int.Parse(textBox3.Text), int.Parse(textBox4.Text));
        }

        private void unir3NUmAscToolStripMenuItem_Click(object sender, EventArgs e)
        {
            obj.Unir3numAsc(int.Parse(textBox3.Text), int.Parse(textBox4.Text), int.Parse(textBox5.Text));
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            obj.SelectParesAsc(this.objN2);
            String salida = String.Concat(objN2.descargar());
            textBox2.Text = salida;
        }

        private void objToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ordAscToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.obj.OrdAsc();
        }

        private void esFiboToolStripMenuItem_Click(object sender, EventArgs e)
        {

            textBox2.Text = this.obj.EsFibo().ToString();
        }
    }
}
