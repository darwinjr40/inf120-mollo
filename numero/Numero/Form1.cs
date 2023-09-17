using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Numero
{
    public partial class Form1 : Form
    {
        Entero obj, objN2;
        string foto1 = "/foto.png";
        string foto2 = "/foto.png";
        string foto3 = "/foto.png";
        string foto4 = "/foto.png";
        string foto5 = "/foto.png";
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

        private void cargarRandToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Random random = new Random();

            int rnd = random.Next(1, 5);
            string foto;
            if (rnd == 1)
            {
                foto = foto1;
            }
            else if (rnd == 2)
            {
                foto = foto2;
            }if (rnd == 3)
            {
                foto = foto3;
            } if (rnd == 4)
            {
                foto = foto4;
            } if (rnd == 5)
            {
                foto = foto5;
            }
            obj.cargar(rnd);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            Interaction.MsgBox(obj.EsEscalera().ToString());
            //Interaction.MsgBox("es la grande (Los 5 dados iguales ) \n es poker (4 dados iguales y el 1 dado diferente) \n es full (2 dados iguales y 3 dados iguales) \n es escalera () \n es trica (3 dados iguales y los otros 2 diferentes) \n Verificar par (2 dados iguales y los otros diferentes) \n ninguna de las anteriores");
        }
    }
}
