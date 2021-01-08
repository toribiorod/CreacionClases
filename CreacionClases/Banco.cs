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
               
            Cliente[0] = new Cliente("Toribio" ,"Roid","aa@aa.com","calle da");
            Cliente[1] = new Cliente("Emma", "Varr", "aa@aa.com", "calle da");
            Cliente[2] = new Cliente("Maria", "Perez", "aa@aa.com", "calle da");

        }
        public void Operar() {
            Cliente[0].Depositar(500);
            Cliente[0].Depositar(1000);
            Cliente[1].Depositar(100);
            Cliente[2].Depositar(150);
            Cliente[0].Extraer(200);

        }
        public void DepositosTotales()
        {

            Cliente[0].RetornarMonto();
            Cliente[0].imprimirOInfo();
            Cliente[1].RetornarMonto();
            Cliente[1].imprimirOInfo();
            Cliente[2].RetornarMonto();
            Cliente[2].imprimirOInfo();
        }
        #endregion

        
    }
}
