using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Numero;
namespace WindowsFormsApplication1
{
    class Matriz
    {
        const int MAXF = 50;
        const int MAXC = 50;
        private int f, c;
        private int[,] m;

        public Matriz()
        {
            this.m = new int[MAXF, MAXC];
            this.f = 0;
            this.c = 0;
        }

        public void CargarRnd(int nf, int nc, int a, int b)
        {
            this.f = nf;
            this.c = nc;
            Random rnd = new Random();
            for (int i = 1; i <= f; i++)
            {
                for (int j = 1; j <= this.c; j++)
                {
                    this.m[i, j] = rnd.Next(a, b); 
                }
            }
        }


        public string Descargar()
        {
            string r = "";
            for (int i = 1; i <= this.f; i++)
            {
                for (int j = 1; j <= this.c; j++)
                {
                    r = r + this.m[i, j] + "\x0009";
                }
                r = r + "\x000d" + "\x000a";   
            }
            return r;
        }


        public void AddColCantPrimos()
        {
            Entero n = new Entero();
            int c;
            for (int i = 1; i <= f; i++)
            {
                c = 0;
                for (int j = 1; j <= this.c; j++)
                {
                    n.cargar(this.m[i, j]);
                    if (n.VerifPrimo())
                        c++; 
                }
                //add elem
                this.m[i, this.c + 1] = c;
            }
            this.c++;
        }
    }
}
