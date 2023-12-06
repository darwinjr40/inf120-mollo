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

        private void Form1_Load(object sender, EventArgs e)
        {
            this.matrices = new Matriz[this.cantidad];
            for (int i = 0; i < this.cantidad; i++)
            {
                this.matrices[i] = new Matriz(); 
            }
            this.m = this.matrices[0];
            this.m.CargarRnd(5, 5, 1, 10);
            textBox5.Text = this.m.Descargar();
            textBox1.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.m.CargarRnd(
                int.Parse(textBox1.Text),
                int.Parse(textBox2.Text),
                int.Parse(textBox3.Text),
                int.Parse(textBox4.Text)
            );
            textBox5.Text = this.m.Descargar();
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



        private void textBox1_Enter(object sender, EventArgs e)
        {
            ((TextBox)sender).Text = "";            
        }

        private void procedureOrdFilCantPrimosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void procedureaddColElemFrToolStripMenuItem_Click(object sender, EventArgs e)
        {            
        }

        private void procedureordColDescToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void procedureOrdsenozoidalToolStripMenuItem_Click(object sender, EventArgs e)
        {            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //this.m.AddColCantPrimos();
            //this.m.OrdFilCantPrimos();
            //this.m.AddElemFr();
            //this.m.Ord2023_1A();
            //this.m.examen2023();
            //this.m.Ordsenozoidal();
            this.m.examen01();
        }

        private void procedureOrdToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void onClick(object sender, EventArgs e)
        {
            //TextBox textBox = (TextBox)sender;
            //textBox.Text = string.Empty;
        }
    }
}
