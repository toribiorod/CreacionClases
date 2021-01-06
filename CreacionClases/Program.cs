using System;
namespace CreacionClases
{
    class Program
    {
        static void Main(string[] args)
        {
            #region "Programa 1"
            /*string nombre;
            int edad;

            Persona per = new Persona();
            Console.WriteLine("Digite el nombre de la persona");
            nombre = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Digite la edad de la persona");
            edad = Convert.ToInt32(Console.ReadLine());

            per.Nombre = nombre;
            per.Edad = edad;
            if (edad >= 18) {
                Console.WriteLine("Es mayor de edad");
            }*/

            #endregion

            #region "Programa 2"

            Triangulo tria = new Triangulo();
            Console.WriteLine("Digite el lado A del Triángulo");
            tria.LadoA = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite el lado B del Triángulo");
            tria.LadoB = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite el lado c del Triángulo");
            tria.LadoC = Convert.ToInt32(Console.ReadLine());
            tria.getMayor(tria.LadoA, tria.LadoB, tria.LadoC);
            tria.getTypeTriangle(tria.LadoA, tria.LadoB, tria.LadoC);


            #endregion

            Console.ReadLine();




        }
    }
}
