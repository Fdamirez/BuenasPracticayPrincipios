using Entity;
using System;

namespace Presentacion
{
    class Program
    {
        static string opc;
        
        static void Main(string[] args)
        {

            Paciente paciente;

            do
            {
                Console.WriteLine("\t\tIPS MAS SALUD Y VIDAD\n");

                Console.WriteLine("\t\tINGRESE LOS RESPECTIVOS DATOS");

                

                Console.WriteLine("\t\tDESEA AGREGAR OTRO PACIENTE \n\t\tSI(S) NO(N)");
                opc = Console.ReadLine();
            } while (opc == "S" && opc == "s");
            Menu();
        }
        public static void Menu()
        {
            do
            {
                Console.WriteLine("\t\t\tMenu de opciones");
                Console.WriteLine("\t\t1) Listado de liquidaciones");
                Console.WriteLine("\t\t2) Consulta por tipo de afiliacion");
                Console.WriteLine("\t\t3) Consulta valor total de cuota");
                Console.WriteLine("\t\t4) Consulta por fecha");
                Console.WriteLine("\t\t5) Consulta por nombre");
                Console.WriteLine("\t\t6) Salir");

            } while (opc == "S" && opc == "s");
        }
    }
}
