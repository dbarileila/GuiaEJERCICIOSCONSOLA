using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAIGUÍA_EJ2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Solicite el ingreso de un texto cualquiera y lo presente nuevamente al usuario.
            Console.Write("Ingrese su nombre: ");
            string nombre = Console.ReadLine();

            Console.Write($"Su nombre es {nombre}");

            Console.ReadKey();
        }
    }
}
