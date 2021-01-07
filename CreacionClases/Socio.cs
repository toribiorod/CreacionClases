using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreacionClases
{
    public class Socio
    {
        #region "Propiedades"
        private string _nombre;
        private int _antiguedad;

        public string Nombre
        {
            get
            {
                return _nombre;
            }
            set { _nombre = value; }
        }
        public int Antiguedad
        {
            get { return _antiguedad; }
            set
            {
                _antiguedad = value;
            }
        }
        #endregion
    }
}
