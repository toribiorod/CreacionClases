using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreacionClases
{
    public class Empleado
    {
        #region "Propiedades"
        private string _nombre;
        private int _sueldo;

        public string Nombre
        {
            get
            {
                return _nombre;
            }
            set { _nombre = value; }
        }
        public int Sueldo
        {
            get { return _sueldo; }
            set
            {
                _sueldo = value;
            }
        }
        #endregion
        #region "Metodos"
        public  void ImprimirDatos()
        {
            Console.WriteLine("----Datos del Empleado----");

            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Sueldo: {Sueldo}");
            Console.WriteLine("----------------------------");
        }
        public void getImpuesto(int sueldo) {

            if (sueldo > 3000) {
                Console.WriteLine("El emppleado debe pagar impuesto");            
            }
        }
        #endregion
    }
}
