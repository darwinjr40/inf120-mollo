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
                    //r = r + this.m[i, j] + "\x0009";
                    r = r + this.m[i, j] + ", ";
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


        public int GetCantPrimos(int fila){
            int cant = 0;
            Entero objEnt = new Entero();
            for (int j = 1; j <= this.c; j++){
                objEnt.cargar(this.m[fila, j]);
                if (objEnt.VerifPrimo())
                    cant++;
            }
            return cant;
        }

        public void inter(int f1,int c1, int f2,int c2)
        {
            int aux = m[f1, c1];
            m[f1, c1] = m[f2, c2];
            m[f2, c2] = aux;
        }
        public void InterFilas(int f1, int f2)
        {
            for (int j = 1; j <= this.c; j++)
                this.inter(f1, j, f2, j);
        }

        public void OrdFilCantPrimos()
        {
            int a, b;
            for (int f1 = 1; f1 <= this.f-1; f1++){
              for (int f2 = f1+1; f2 <= this.f; f2++){
                  a = this.GetCantPrimos(f1);
                  b = this.GetCantPrimos(f2);
                  if (a > b)
                      this.InterFilas(f1, f2);
              }
            }
        }

        public int frec(int i, int a, int b, int x)
        {
            int cant = 0;
            for (int j = a; j <= b; j++)
            {
                if (this.m[i, j] == x)
                    cant++;
            }
            return cant;
        }

        public void CargarEleFr(int i, ref int e, ref int fr)
        {
            e = 0;
            fr = 0;
            int a;
            for (int j = 1; j <= this.c; j++)
            {
                a = this.frec(i, 1, this.c, m[i, j]);
                if (a > fr)
                {
                    fr = a;
                    e = m[i, j];
                }
            }
        }

        public void AddElemFr()
        {
            int e=0, fr=0;
            for (int i = 1; i <= this.f; i++)
            {
                this.CargarEleFr(i, ref e, ref fr);
                this.m[i, this.c + 1] = e;
                this.m[i, this.c + 2] = fr;
            }
            this.c = this.c + 2;
        }


        public void OrdInterCol(int j, int a, int b)
        {
            for (int i = a; i <= b-1; i++)
            {
                for (int ii = i+1; ii <= b; ii++)
                {
                    if (this.m[i, j] < this.m[ii, j])                    
                        this.inter(i, j, ii, j);                    
                } 
            }
        }
        public void Ord2023_1A()
        {
            for (int j = 1; j <= this.c - 1; j++)
                this.OrdInterCol(j, j + 1, c);
        }


        public void Ordsenozoidal()
        {
            bool sw = true;
            int fi;
            for (int j = 1; j <= this.c; j++)
            {
                if (sw)
                {
                    for (int i = this.f; i >= 1; i--)
                    {
                        for (int jj = j; jj <= this.c; jj++)
                        {
                            fi = (jj == j) ? (i) : (this.f);
                            for (int ii = fi; ii >= 1; ii--)
                                if (this.m[i, j] > this.m[ii, jj])
                                    this.inter(i, j, ii, jj); 
                        } 
                    }
                }
                else
                {
                    for (int i = 1; i <= this.f; i++)
                    {
                        for (int jj = j; jj <= this.c; jj++)
                        {
                            fi = (jj == j) ? (i) : (1);
                            for (int ii = fi; ii <= this.f; ii++)                            
                                if (this.m[i, j] > this.m[ii, jj])
                                    this.inter(i, j, ii, jj); 
                            
                        }
                    }
                }
                sw = !sw;
            }
        }

        public void examen2023()
        {
            int co;
            for (int i = 2; i <= this.f; i++)
			{
                for (int j =  this.c-i+2; j <= this.c; j++)
                {
                    for (int ii = i; ii <= this.f; ii++)
                    {
                       co = (ii == i) ? (j) : (this.c-ii+2);
                       for (int jj = co; jj <= this.c; jj++)
                       {
                           if (this.m[i, j] > this.m[ii, jj])
                                    this.inter(i, j, ii, jj); 
                       }
                    } 
                }
			}
        }
    }
}
