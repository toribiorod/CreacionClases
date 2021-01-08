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
        #region "Metodos"
        public Socio() {
            Console.WriteLine("Digite el nombre");
            Nombre = Console.ReadLine();
            Console.WriteLine("Digite la antiguedad");
            Antiguedad = int.Parse(Console.ReadLine());
        }
        public void imprimirDatos() {

            Console.WriteLine("El socio" + Nombre + "es que tiene una mayor antiguedad  y es de : " + Antiguedad );
        }
        public int getAntiguedad() {

            return Antiguedad;
        }
        #endregion
    }
}
