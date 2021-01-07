using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreacionClases
{
    public class Alumno
    {
        #region "Propiedades"
        private string _nombre;
        private int _edad;

        public string Nombre
        {
            get
            {
                return _nombre;
            }
            set { _nombre = value; }
        }
        public int Edad
        {
            get { return _edad; }
            set
            {
                _edad = value;
            }
        }
        #endregion
        #region "Metodos"
        public Alumno() {
            Nombre = "Toribio";
            Edad = 15;        
        }
        public void imprimirDatos() {
            Console.WriteLine("El nombre es: {0}", Nombre);
            Console.WriteLine("La edad es : {0} " , Edad);
        }
        public void mostrarMensajeEdad() {
            if (Edad >= 18)            {
                Console.WriteLine("Su edad es {0} y es mayor de edad", Edad);
            }
            else {
                Console.WriteLine("Su edad es {0} y es menor de edad", Edad);
            }
        }
        #endregion
    }
}
