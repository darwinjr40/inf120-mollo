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

    }
}
