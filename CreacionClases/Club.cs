using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreacionClases
{
    public class Club
    {
        #region "Propiedades"
        private Socio[] Socio;
        #endregion
        public Club() {
            Socio = new Socio[3];

            Socio[0] = new Socio();
            Socio[1] = new Socio();
            Socio[2] = new Socio();
        }
        public void obtenerMayorAntiguedad() {
            if (Socio[0].getAntiguedad() < Socio[1].getAntiguedad())
            {
                if (Socio[1].getAntiguedad() < Socio[2].getAntiguedad())
                {
                    Socio[2].imprimirDatos();
                }
                else
                    Socio[1].imprimirDatos();
            }
            else if (Socio[0].getAntiguedad() > Socio[1].getAntiguedad())
            {
                if (Socio[1].getAntiguedad() < Socio[2].getAntiguedad())
                {
                    Socio[2].imprimirDatos();
                }
                else
                    Socio[0].imprimirDatos();
            }

        }
    }
}
