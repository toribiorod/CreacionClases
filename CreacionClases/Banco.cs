using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreacionClases
{
    public class Banco
    {
        #region "Propiedades"
        private Cliente[] Cliente;
        #endregion
        #region "Metodos"

        public Banco()
        {
            Cliente = new Cliente[3];
            for (int i = 0; i < Cliente.Length; i++)
            {
                Cliente[i] = new Cliente(names[i], charge);
            }
        }
        public void Operar() { 
        
        }
        public void DepositosTotales()
        {

        }
        #endregion

        
    }
}
