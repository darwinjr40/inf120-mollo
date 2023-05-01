using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic;
using System.Windows.Forms;
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
        public void Cargar(int dim)
        {
            n = dim;
            for (int i = 1; i <= n; i++)
            {
              v[i] = int.Parse(Interaction.InputBox("v["+ i.ToString() +"]", "Ingrese Elemento"));
            }
        }

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
        //-----------------------------------------------------------
        //busca x en el vector, retorna la posicion
        public int BusqSec(int a, int b, int x)
        {
            int i = a;
            while ((i <= b) ){
                if (v[i] == x)
                    return i;
                i++;
            }
            return 0;          
        }

        public bool BusqSecu(int a, int b, int x)
        {
            int pos = this.BusqSec(a, b, x);
            return ( pos > 0);
        }

        //-----------------------------------------------------------
        public void Intersec(Vector v1, Vector v2)
        {
            int i = 1;
            int ele;
            while (i <= v1.n)
            {
                ele = v1.v[i];
                if (v2.BusqSecu(1, v2.n, ele))
                {
                    this.addElem(ele); 
                }
                i++;  
            }
        }
        //-----------------------------------------------------------

        public void Union(Vector v1, Vector v2)
        {
            
            int ele;
            for (int i = 1; i <= v1.n; i++)
            {
                ele = v1.v[i];
                this.addElem(ele);
            }

            for (int i = 1; i <= v2.n; i++)
            {
                ele = v2.v[i];
                if (! this.BusqSecu(1, this.n, ele))
                  this.addElem(ele);  
            }
        }
    }
}
