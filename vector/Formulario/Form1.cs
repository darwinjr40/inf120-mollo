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

namespace Formulario
{
    public partial class Form1 : Form
    {
        Vector vector;
        Vector vector1;
        Vector vector2;
        public Form1()
        {
            InitializeComponent();
        }

        private void cargarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                int dim = int.Parse(textBox1.Text);
                int a = int.Parse(textBox2.Text);
                int b = int.Parse(textBox3.Text);
                this.vector.CargarRamdom(dim, a, b);
                this.textBox4.Text = this.vector.Descargar();
            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.Message);
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.vector = new Vector();
            this.vector1 = new Vector();
            this.vector2 = new Vector();
            textBox2.ForeColor = SystemColors.WindowText;
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

        private void cargarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                int dim = int.Parse(textBox1.Text);
                this.vector.Cargar(dim);
                this.textBox4.Text = this.vector.Descargar();
            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.Message);
            }
            
        }

        private void interseccionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vector.Intersec(vector1, vector2);
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void cargarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            try
            {
                int dim = int.Parse(textBox1.Text);
                this.vector1.Cargar(dim);
                this.textBox4.Text = this.vector1.Descargar();
            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.Message);
            }   
            
        }

        private void decargarv2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.textBox5.Text = this.vector1.Descargar();
        }

        private void cargarv2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                int dim = int.Parse(textBox1.Text);
                this.vector2.Cargar(dim);
                this.textBox4.Text = this.vector2.Descargar();
            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.Message);
            }            
        }

        private void descargarv2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.textBox5.Text = this.vector2.Descargar();
        }

        private void unionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vector.Union(vector1, vector2);
        }

        private void cargarMayMenConFrecToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                int a = int.Parse(textBox2.Text);
                int b = int.Parse(textBox3.Text);
                vector.CargarElemMayMenWithFrec(a, b, vector1, vector2);
            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.Message);
            }
            
        }

        private void cantidadNumPrimDifereToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox2.Text);
            int b = int.Parse(textBox3.Text);
            this.textBox5.Text = this.vector.GetCantNumPrimosUnicos(a, b).ToString();
        }

        private void diferenciaSimetricav1v2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.vector.DifSimetrica(vector1, vector2);
            //Interaction.MsgBox(nro.ToString());
        }

        private void eliminarRepetidosDejandoUnicosabToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox2.Text);
            int b = int.Parse(textBox3.Text);
            this.vector.DeleteYDejarElemUnicos(a, b);
        }

        private void ordenarExtremosabToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                int a = int.Parse(textBox2.Text);
                int b = int.Parse(textBox3.Text);
                vector.EndsSort(a, b);
            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.Message);
            }
        }

        private void cargarrndnoRepToolStripMenuItem_Click(object sender, EventArgs e)
        {
             try
            {
                int dim = int.Parse(textBox1.Text);
                int a = int.Parse(textBox2.Text);
                int b = int.Parse(textBox3.Text);
                this.vector.CargarRamdomNoRep(dim, a, b);                
            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.Message);
            }            
        }

        private void cargarfiboYFrecToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {                
                int a = int.Parse(textBox2.Text);
                int b = int.Parse(textBox3.Text);
                vector.LoadFiboAndFrec(a, b, vector1, vector2);
            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.Message);
            } 
            
        }

        private void practico20232ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //int mult = int.Parse(Interaction.InputBox("", "", ""));
            //double media = this.vector.GetMediaPos(mult);
            //textBox5.Text = media.ToString();
            try
            {
                int a = int.Parse(textBox2.Text);
                int b = int.Parse(textBox3.Text);
                //this.vector.Invertir(a, b);
                //this.vector.Invertir();
                //this.vector.SegCapiAndNotCapi();
                //int res = this.vector.BuscElemMenFr(a, b);
                //Interaction.MsgBox(res.ToString());
                //this.vector.add(a, b);
                //this.vector.add(this.vector1, a);

                //DeletePosMult
                //int cantElem = vector.GetCantElemDif(a, b);
                //textBox5.Text = "Diferentes: " + cantElem.ToString();

                //DeletePosMult
                int m = int.Parse(Interaction.InputBox("", "ingrese valor para m:", ""));
                vector.DeletePosMult(1, vector.GetN(), m);
            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.Message);
            } 
            
        }
    }
}
