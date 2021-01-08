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
            /*
            Triangulo tria = new Triangulo();
            Console.WriteLine("Digite el lado A del Triángulo");
            tria.LadoA = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite el lado B del Triángulo");
            tria.LadoB = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite el lado C del Triángulo");
            tria.LadoC = Convert.ToInt32(Console.ReadLine());
            tria.getMayor(tria.LadoA, tria.LadoB, tria.LadoC);
            tria.getTypeTriangle(tria.LadoA, tria.LadoB, tria.LadoC);

            */
            #endregion

            #region "Programa 3"
            /*Plano pla = new Plano();
            Console.WriteLine("Digite el lado X del Triángulo");
            pla.X = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite el lado Y del Triángulo");
            pla.Y = Convert.ToInt32(Console.ReadLine());
            pla.getCuadrante(pla.X, pla.Y);*/
            #endregion
            #region "Programa 4"
            /*Cuadrado cua = new Cuadrado();
            Console.WriteLine("Digite el lado A del Cuadrado");
            cua.LadoA = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite el lado B del Cuadrado");
            cua.LadoB = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite el lado C del Cuadrado");
            cua.LadoC = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite el lado D del Cuadrado");
            cua.LadoD = Convert.ToInt32(Console.ReadLine());

            cua.getPerimetro(cua.LadoA, cua.LadoB, cua.LadoC , cua.LadoD);
            cua.getSuperficie(cua.LadoA, cua.LadoB, cua.LadoC, cua.LadoD);*/
            #endregion

            #region "Programa 5"
            //ObtenerDatosEmpleado();
            #endregion
            #region "Programa 6"
            //RealizaOperaciones();
            #endregion
            #region "Programa 7"
            /*Tabla tabl = new Tabla();
            do { 
                Console.WriteLine("Digite un número para hacer la tabla");
                tabl.Num1 = Convert.ToInt32(Console.ReadLine());
                tabl.obtenerTabla(tabl.Num1);
            } while (tabl.Num1 != -1);*/
            #endregion
            #region "Programa 8"
            /* MayorMenor may = new MayorMenor();
             Console.WriteLine("Digite el número 1");
             may.Num1 = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("Digite el número 2");
             may.Num2 = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("Digite el número 3");
             may.Num3 = Convert.ToInt32(Console.ReadLine());
             may.getMayor(may.Num1, may.Num2, may.Num3);
             may.getMenor(may.Num1, may.Num2, may.Num3);*/
            #endregion
            #region "Programa 9"
            /*VectorOperarios vec = new VectorOperarios();
            vec.mostrarSueldo();*/
            #endregion

            #region "Programa 10"
            /*Alumno alu = new Alumno();
            alu.imprimirDatos();
            alu.mostrarMensajeEdad();*/
            #endregion

            #region "Programa 11"
            /* Banco ban = new Banco();
             ban.Operar();
             ban.DepositosTotales(); */
            #endregion
            #region "Programa 12"
            Club club = new Club();
            club.obtenerMayorAntiguedad();
            #endregion

            Console.ReadLine();
        }
        #region "metodos "
        static void ObtenerDatosEmpleado()
        {

            Empleado empl = new Empleado()
            {
                Nombre = "Toribio ",
                Sueldo= 5000
            };

            empl.ImprimirDatos();
            empl.getImpuesto(empl.Sueldo);
            Console.ReadLine();

        }
        static void RealizaOperaciones()
        {

            Operaciones ope = new Operaciones()
            {
                Num1 = 10,
                Num2 = 3
            };
            ope.ImprimirDatos();
            ope.obtieneSuma(ope.Num1 , ope.Num2);
            ope.obtieneResta(ope.Num1, ope.Num2);
            ope.obtieneMulticacion(ope.Num1, ope.Num2);
            ope.obtieneDivision(ope.Num1, ope.Num2);
            Console.ReadLine();

        }
        #endregion


    }
}

