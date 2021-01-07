using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreacionClases
{
    public class VectorOperarios
    {
        private int[] sueldos;

        public VectorOperarios()
        {
            sueldos = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Ingrese el sueldo {0}:",i + 1);
                String linea;
                linea = Console.ReadLine();
                sueldos[i] = int.Parse(linea);
            }
        }
        public void mostrarSueldo() {
            Console.WriteLine("------------Los sueldos ingresados son:--------------");
            for (int i = 0; i < sueldos.Length; i++)
            {
                Console.WriteLine("Sueldo {0}", sueldos[i]);
            }
        
        }
    }
}
