using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreacionClases
{
    public class Cliente
    {

        #region "Propiedades"
        private string _nombre;
        private string _apellido;
        private string _correo;
        private string _direccion;
        private int _monto;
        public string Nombre
        {
            get
            {
                return _nombre;
            }
            set { _nombre = value; }
        }
        public string Apellido
        {
            get
            {
                return _apellido;
            }
            set { _apellido = value; }
        }
        public string Correo
        {
            get
            {
                return _correo;
            }
            set { _correo = value; }
        }
        public string Direccion
        {
            get
            {
                return _direccion;
            }
            set { _direccion = value; }
        }
        public int Monto
        {
            get
            {
                return _monto;
            }
            set { _monto = value; }
        }
        #endregion
        #region "Metodos"
        public Cliente() { }
        public Cliente(string nombre, string apellido, string correo, string dirrecion) {
            Nombre = nombre;
            Apellido = apellido;
            Correo = correo;
            Direccion = dirrecion;
            Monto = 0;
        }
        public void Depositar(int monto) {
            Monto = Monto + monto;
        }
        public void Extraer(int monto)
        {
            Monto = Monto - monto;
        }
        public int RetornarMonto()
        {
            return Monto;
        }
        #endregion

    }
}
