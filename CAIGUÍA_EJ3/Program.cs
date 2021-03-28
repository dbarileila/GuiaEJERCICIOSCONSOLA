using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAIGUÍA_EJ3
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo TECLAS;
            do
            {
                TECLAS = Console.ReadKey(true);


            } while (TECLAS.Key != ConsoleKey.X);
        }
    }
}
