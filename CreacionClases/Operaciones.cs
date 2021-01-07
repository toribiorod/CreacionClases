using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreacionClases
{
    public class Operaciones
    {
        #region "Propiedades"
        private int _num1;
        private int _num2;
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
        #endregion
        #region "Metodos"

        public void obtieneSuma(int num1, int num2) {
            Console.WriteLine("La suma es {0}", num1+num2);
        }
        public void obtieneResta(int num1, int num2) {
            Console.WriteLine("La resta es {0}", num1 - num2);
        }
        public void obtieneMulticacion(int num1, int num2) {
            Console.WriteLine("La multiplicación es {0} ", num1 * num2);
        }
        public void  obtieneDivision(int num1, int num2) {
            if (num2 != 0)
            {
                Console.WriteLine("La division es {0}", (float)num1 / num2);
            }
            else {
                Console.WriteLine("El denominador no puede ser cero");
            }

        }
        public void ImprimirDatos()
        {
            Console.WriteLine("----Números introducidos----");

            Console.WriteLine($"Num1: {Num1}");
            Console.WriteLine($"Num2: {Num2}");
            Console.WriteLine("----------------------------");
        }
        #endregion

    }

}
