using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAIGUÍA_EJR4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Permita el ingreso de frases, finalizando cuando el usuario ingresa “fin”.
            string igualdad;

            do
            {
                Console.Write("Escriba fin para finalizar: ");
                igualdad = Console.ReadLine();

            } while (igualdad != "fin");

        }
    }
}
