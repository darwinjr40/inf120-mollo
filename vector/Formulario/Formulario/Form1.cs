using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulario
{
    public partial class Form1 : Form
    {
        Vector vector;
        public Form1()
        {
            InitializeComponent();
        }

        private void cargarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int dim = int.Parse(textBox1.Text);
            int a = int.Parse(textBox2.Text);
            int b = int.Parse(textBox3.Text);
            this.vector.CargarRamdom(dim, a, b);
            this.textBox4.Text = this.vector.Descargar();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.vector = new Vector();
        }

        private void descargarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.textBox5.Text = this.vector.Descargar();
        }

        private void exaelimFiboToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox2.Text);
            int b = int.Parse(textBox3.Text);
            this.vector.ElimElemFibo(a, b);
        }

        private void exaintercaMayMenInvertidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox2.Text);
            int b = int.Parse(textBox3.Text);
            this.vector.IntercalarMayMenInvertido(a, b);
        }
    }
}
