using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {        
        Matriz[] matrices;
        Matriz m;
        int cantidad = 4;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.matrices = new Matriz[this.cantidad];
            for (int i = 0; i < this.cantidad; i++)
            {
                this.matrices[i] = new Matriz(); 
            }
            this.m = this.matrices[0];
            //this.m = new Matriz();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.m.CargarRnd(
                int.Parse(textBox1.Text),
                int.Parse(textBox2.Text),
                int.Parse(textBox3.Text),
                int.Parse(textBox4.Text)
            );
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox6.Text = this.m.Descargar();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //textBox5.Text = this.comboBox1.SelectedIndex.ToString();
            this.m = this.matrices[this.comboBox1.SelectedIndex];
            textBox5.Text = this.m.Descargar();
        }

        private void procedureAddColCantPrimosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.m.AddColCantPrimos();
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            //textBox1.Text = "filas";
            //textBox1.ForeColor = SystemColors.GrayText;
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            //if (textBox1.Text == "filas")
            //{
            //    textBox1.Text = "";
            //    textBox1.ForeColor = SystemColors.WindowText;
            //}
        }

        private void procedureOrdFilCantPrimosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.m.OrdFilCantPrimos();
        }

        private void procedureaddColElemFrToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.m.AddElemFr();
        }

        private void procedureordColDescToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.m.Ord2023_1A();
        }

        private void procedureOrdsenozoidalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.m.Ordsenozoidal();
            this.m.examen2023();
        }
    }
}
