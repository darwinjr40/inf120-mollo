using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                v[i] = rand.Next(a, b + 1);
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
        //public void Inter(int a, int b)
        //{
        //    int aux = v[a];
        //    v[a] = v[b];
        //    v[b] = aux;
        //}

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

        //-----------------------------------------------------------
        public int GetFrec(int a, int b, int x)
        {
            int r = 0;
            while (a <= b)
            {
                if (this.v[a] == x)                
                    r++;
                a++;    
            }
            return r;
        }
        public int GetFrec(int x)
        {
            //if (this.n == 0)
            //    throw new Exception("vector vacio");
            
            return this.GetFrec(1, this.n, x); 
        }

        public bool Pertenece(int a, int b, int x)//x=5   => 2
        {
            return (this.GetFrec(a,b,x) > 0);
        }

        public bool Pertenece(int x)//x=5   => 2
        {
            return (this.GetFrec(x) > 0);
        }
        //-----------------------------------------------------------

        public void CargarElemMayMenWithFrec(int a, int b, Vector v1, Vector v2)
        {            
            if (n > 0)
            {                                           
                v1.n = 0;
                v2.n = 0;
                int fr = this.GetFrec(a, b, this.v[1]);
                v1.addElem(this.v[1]);
                v1.addElem(this.v[1]);

                v2.addElem(fr);
                v2.addElem(fr);
                int i = 2; 
                while (i <= this.n)
                {
                    fr = this.GetFrec(a, b, this.v[i]);
                    if (fr < v2.v[1]) //men
                    {
                        v1.v[1] = v[i];
                        v2.v[1] = fr;
                    }
                    if (fr > v2.v[2]) //may
                    {
                        v1.v[2] = v[i];
                        v2.v[2] = fr;
                    }
                    i++; 
                }
            }
        }

        //-----------------------------------------------------------

        public int GetCantNumPrimosUnicos(int a, int b)
        {
            int i = a;
            int c = 0;
            Entero objEntero = new Entero();            
            while (i <= b)
            {
                Interaction.MsgBox(this.v[i].ToString());
                objEntero.cargar(this.v[i]);
                if (objEntero.VerifPrimo())
                {
                    //if (this.Pertenece(a, i-1, this.v[i] ))
                    if ( ! this.Pertenece(a, i - 1, objEntero.descargar()))
                    {
                        c++;  
                    }    
                }
                i++;
            }
            return c;
        }

        //-----------------------------------------------------------
        public void DifSimetrica(Vector v1, Vector v2)
        {
            this.n = 0;
            int a;
            for (int i = 1; i <= v1.n; i++)
            {
                a = v1.v[i];
                if (!v2.Pertenece(a) && v1.Pertenece(v1.v[i]))                    
                    this.addElem(a);
                //if (!v2.Pertenece(a) && (!this.Pertenece(a)))
            }
            for (int i = 1; i <= v2.n; i++)
                if ( (! v1.Pertenece(v2.v[i])) && (!this.Pertenece(v2.v[i])))
                    this.addElem(v2.v[i]);
        }
        //-----------------------------------------------------------
        public void DeleteYDejarElemUnicos(int a, int b)
        {
            int dim, e;
            dim = this.n;
            this.n = a - 1;
            for (int i = a; i <= dim; i++)
            {
                e = this.v[i];
                if (i > b)
                    this.addElem(e);
                else if (! this.Pertenece(a, i-1, e))
                         this.addElem(e);
            }
        }

        //-----------------------------------------------------------
        //modelo 2023-1
        //retorna la posicion del elemento menor
        public int GetPosElemMenor(int a, int b){
            int pos = a;
            a++;
            while (a <= b){
                if (this.v[a] < this.v[pos])                   
                    pos = a;
                a++;    
            }
            return pos;
        }
        //intercambia dos posiciones del vector
        public void Inter(int a, int b)
        {
            int aux = v[a];
            v[a] = v[b];
            v[b] = aux;
        }
        //ordenar los extremos de manera ascendente
        public void EndsSort(int a, int b){
            bool sw = true;
            int pos;
            while (a < b) {
                pos = this.GetPosElemMenor(a, b);
                if (sw){                                     
                    this.Inter(a, pos);                      
                    a++;
                } else {
                    this.Inter(b, pos);                    
                    b--;
                }
                sw = !sw;
            }
        }
        //------------------------------
        bool Existe(int a, int b, int x)
        {
            bool sw = false;
            while( (a <= b) && (!sw)){
                if (v[a] == x) sw = true;                
                a++;
            }
            return sw;
        }

        public void CargarRamdomNoRep(int cant, int a, int b)
        {
            n = 0;
            Random rand = new Random();
            while(n <= cant){
                int x = rand.Next(a+1, b + 1);
                if (!this.Existe(1, n, x)){
                    n++;
                    v[n] = x;                    
                }                                  
            }
        }

        //------------------------------
    }
}
