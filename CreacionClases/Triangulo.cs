using System;

namespace CreacionClases
{
    public class Triangulo
    {
        #region "Propiedades"
        private int _ladoA;
        private int _ladoB;
        private int _ladoC;
        public int LadoA
        {
            get { return _ladoA; }
            set
            {
                _ladoA = value;
            }
        }
        public int LadoB
        {
            get { return _ladoB; }
            set
            {
                _ladoB = value;
            }
        }
        public int LadoC
        {
            get { return _ladoC; }
            set
            {
                _ladoC = value;
            }
        }
        #endregion
        #region "Metodos"
        public void getMayor(int a, int b, int c) {
            if (a < b)
            {
                if (b < c)
                {
                    Console.WriteLine("El lado C es mayor con {0} ", c);
                }
                else
                    Console.WriteLine("El lado b es mayor con {0} ", b);
            }
            else if (a > b)
            {
                if (a < c)
                {
                    Console.WriteLine("El lado C es mayor con {0} ", c);
                }
                else
                    Console.WriteLine("El lado A es mayor con {0} ", a);
            }

        }
        public void getTypeTriangle(int a, int b, int c) {
            if (a == b && b == c)
            {
                Console.WriteLine("El triángulo es equilátero");
            }
            else
            {
                Console.WriteLine("El triángulo  no es equilátero");
            }
        }

        #endregion

    }
}
