using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreacionClases
{
    public class Plano
    {
        #region "Propiedades"
        private int _x;
        private int _y;

        public int X
        {
            get { return _x; }
            set
            {
                _x = value;
            }
        }
        public int Y
        {
            get { return _y; }
            set
            {
                _y = value;
            }
        }
        #endregion
        #region "Metodos"

        public void getCuadrante(int x, int y) {

            if (x > 0 && y > 0)
            {
                Console.WriteLine("El punto ({0}, {1}) está en el  Primer Cuandrante", x,y);
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("El punto ({0}, {1}) está en el Segundo Cuandrante", x, y);
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("El punto ({0}, {1}) está en el Tercer Cuandrante", x, y);
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine("El punto ({0}, {1}) está en el Cuarto Cuandrante", x, y);
            }
            else {

                Console.WriteLine("El punto ({0}, {1}) está en el Está en el origen", x, y);
            }

        }
        #endregion
    }
}
