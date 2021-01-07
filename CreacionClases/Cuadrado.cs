using System;

namespace CreacionClases
{
    public class Cuadrado
    {
        #region "Propiedades"
        private int _ladoA;
        private int _ladoB;
        private int _ladoC;
        private int _ladoD;
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
        public int LadoD
        {
            get { return _ladoD; }
            set
            {
                _ladoD = value;
            }
        }
        #endregion
        #region "Metodos"
        public void getPerimetro(int a, int b, int c, int d) {
            if (a == b && b == c && c == d)
            {
                Console.WriteLine("El perimetro es  {0}", a+b+c+d);
            }
            else
            {
                Console.WriteLine("La figura no es un cuadrado");

            }

        }
        public void getSuperficie(int a, int b, int c, int d)
        {

            if (a == b && b == c && c == d)
            {
                Console.WriteLine("La superficie es {0}", Math.Pow(a, 2));
            }
            else {
                Console.WriteLine("La figura no es un cuadrado");
            
            }

        }
        #endregion
    }
}
