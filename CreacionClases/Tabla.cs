using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreacionClases
{
    public class Tabla
    {
        #region "Propiedades"
        private int _num1;
        public int Num1
        {
            get { return _num1; }
            set
            {
                _num1 = value;
            }
        }
        #endregion
        public void obtenerTabla(int num1) {
            if (num1 != -1)
            {
                for (int i = 0; i <= 10; i++)
                {
                    Console.WriteLine(num1 + "x" + i + "=" + (i * num1));
                }

            }
            
        }
    }
}
