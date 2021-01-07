using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreacionClases
{
    class MayorMenor
    {
        #region "Propiedades"
        private int _num1;
        private int _num2;
        private int _num3;
        public int Num1
        {
            get { return _num1; }
            set
            {
                _num1 = value;
            }
        }
        public int Num2
        {
            get { return _num2; }
            set
            {
                _num2 = value;
            }
        }
        public int Num3
        {
            get { return _num3; }
            set
            {
                _num3 = value;
            }
        }
        #endregion
        #region "Metodos"
        public void getMayor(int a, int b, int c)
        {
            if (a < b)
            {
                if (b < c)
                {
                    Console.WriteLine("El número es mayor {0} ", c);
                }
                else
                    Console.WriteLine("El número es mayor {0} ", b);
            }
            else if (a > b)
            {
                if (a < c)
                {
                    Console.WriteLine("El número es mayor {0} ", c);
                }
                else
                    Console.WriteLine("El número es mayor {0} ", a);
            }

        }
        public void getMenor(int a, int b, int c)
        {
            if (a < b && a < c)
            {
                Console.WriteLine("El número menor es " + a);
            }
            else
            {
                if (b < a && b < c)
                {
                    Console.WriteLine("El número menor es " + b);
                }
                else
                {
                    Console.WriteLine("El número menor es " + c);
                }
            }

        }

        #endregion
    }
}
