using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Numero;
namespace Formulario
{
    class Vector
    {
        //definicion de atributos 
        int[] v; 
        int n;
        //constructor, asignacion de atributos
        public Vector()
        {   
            v = new int[100];
        }
        //metodos
        //public void Cargar(int x)
        //{
        //    n = x;
        //    for (int i = 1; i <= n; i++)
        //    {
        //      v[i] =     
        //    }
        //}

        public void CargarRamdom(int x, int a, int b)
        {
            n = x;
            Random rand = new Random();
            for (int i = 1; i <= n; i++)
            {
                v[i] = rand.Next(a, b + 1); ;   
            }
        }

        public String Descargar()
        {
            string r = "";
            for (int i = 1; i <= n; i++)
            {
                r = r + v[i].ToString();
                if (i < n)
                {
                    r = r + ", ";   
                }
            }
            return r;
        }
        public void addElem(int x)
        {
            this.n++;
            v[n] = x;
        }
        //eliminar los elementos de fibonacci entre rango a  y b
        public void ElimElemFibo(int a, int b)
        {
            int x;
            int dim = this.n;
            Entero objEnt = new Entero();
            n =  a -1;
            for (int i = a; i <= b; i++)
            {
                x = v[i];
                objEnt.cargar(x);
                if (!objEnt.EsFibo())
                {
                    this.addElem(x);    
                }
            }
            for (int i = b+1; i <= dim; i++)
            {
                x = v[i];
                this.addElem(x);   
            }
        }

        //intercambia dos posiciones del vector
        public void Inter(int a, int b)
        {
            int aux = v[a];
            v[a] = v[b];
            v[b] = aux;
        }

        public void IntercalarMayMenInvertido(int a, int b)
        {
            bool sw = true;
            int x, y;
            for (int i = b; i >= (a+1); i--)
            {
                for (int j = (i-1); j >= a; j--)
                {
                    x = v[i];
                    y = v[j];
                    if (sw) //mayor
                    {
                        if (y > x)
                        {
                            this.Inter(i, j);  
                        }
                    }
                    else//menor
                    {
                        if (y < x)
                        {
                            this.Inter(i, j);
                        }
                    }
                }
                sw = !sw;
            }
        }

    }
}
