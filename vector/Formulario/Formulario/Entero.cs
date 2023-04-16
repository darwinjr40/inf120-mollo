using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numero
{
    class Entero
    {
        //atributos
        private int n;
        //constructor----------------------------------
        //ENseguida empezamos,   Hay algo para resolver??
        //pasen al grupo !!!
        public Entero() //inicial
        {
            n = 0;
        }
        public Entero(int x) //parametrisado
        {
            n = x;
        }

        public Entero(Entero objeto) //copia
        {
            n = objeto.n;
        }


        //metodos
        public void cargar(int x)
        {
            n = x;
        }

        public int descargar()
        {
            return n;
        }

        public bool VerifPrimo()
        {
            int i = n / 2;
            while (i > 1)
            {
                if (n % i == 0)
                {
                    return false;
                }
                i--; // i = i - 1;
            }
            return true;
        }

        public void Invertir()
        {
            int d,
                num = 0;
            while (n > 0)
            {
                d = n % 10;
                n = n / 10;
                num = num * 10 + d;
            }
            this.n = num; // n = num
        }

        public bool EsCapicua()
        {
            Entero aux = new Entero(n); //aux.n = n = 123
            aux.Invertir(); // aux = 321
            return (n == aux.n); //123 = 321
        }

        public bool EsMultiplo(int x)
        {            
            return (n % x == 0); 
        }

        public int GetCantDig()
        {
            return (n == 0) ? 1 : (int) Math.Log10(n) + 1;

            //if (n == 0)
            //{
            //    return 1;
            //}
            //else
            //{
            //    return (int)Math.Log10(n) + 1;
            //}
        }
        //n = 5   x = 80   => n = 580

        public static int Pot(int b, int exp)
        {
            return (int)Math.Pow(b, exp);
        }
        public void UnirNumDerecha(int x)
        {
            if (x > 0)
            {
                Entero aux = new Entero(x);
                n = n * Entero.Pot(10,aux.GetCantDig()) + x;
            }
        }
        //Unir dos números enteros, al menor el mayor
        //n1{n=34 n2{n=12 => n3{n=1234
        public void Unir2numAsc(int a, int b)
        {
            if (a >= b)
            {
                this.UnirNumDerecha(b);
                this.UnirNumDerecha(a);
            }
            else
            {
                this.UnirNumDerecha(a);
                this.UnirNumDerecha(b);
            }
        }  
        //Unir 3 números enteros, el menor, intermedio y el mayor. 
        //n1{n=34 n2{n=12 n3{n=20 => n4{n=122034
        public void Unir3numAsc(int a, int b, int c)
        {
            if (a >= b && a >= c)  //el mayor es a
            {
                Unir2numAsc(b, c);
                UnirNumDerecha(a);
            }
            else if (b >= a && b >= c) //el mayor es b
            {
                Unir2numAsc(a, c);
                UnirNumDerecha(b);
            }
            else if (c >= a && c >= b) //el mayor es c
            {
                Unir2numAsc(a, b);
                UnirNumDerecha(c);
            }
        }
        //13. Ordenar los dígitos de un numero entero.
        //n1{n=26482 => n1{n=22468
        public void OrdAsc()
        {
            int d;
            int num = this.n;
            this.cargar(0); //n = 0;
            while (num > 0)
            {
                d = num % 10;
                num = num / 10;                
                this.InsertAsc(d);                
            }
        }

        //15. Seleccionar dígitos primos de un número entero en otro objeto ordenado.
        //n1{n=263472 => n2{n=2237
        //public void SelectParesAsc(int x)
        public void SelectParesAsc(Entero x)
        {
            int d;
            Entero aux = new Entero();
            int num = this.n;
            x.cargar(0); //x.n = 0;
            while (num > 0)
            {
                d = num % 10;
                num = num / 10;
                aux.cargar(d);  //aux.n = d;
                if (aux.VerifPrimo())
                {
                    x.InsertAsc(d);  
                }                
            }
        }

        public void InsertAsc(int d)
        {
            int aux = 0,
                 p  = 1;
            while (d <= (n%10))
            {
                aux = (n % 10) * p + aux;
                p = p * 10;
                n = n / 10;
            }
            this.n = n * 10 + d;
            this.UnirNumDerecha(aux);
        }


        public bool EsFibo(){
            int a = 0;
            int b = 1;
            int c = 1;
            while (c <= this.n)
            {
                if (c == n)
                {
                    return true;
                }
                c = a + b;
                a = b;
                b = c;
            }
            return false;
        }
    }
}
