using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAIEJR5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Lea las teclas presionadas y finalice al presionar Ctrl+F (Ctrl y F al mismo tiempo).

            ConsoleKeyInfo teclas;
            Console.TreatControlCAsInput = true;

            do
            {
                teclas = Console.ReadKey();
                Console.WriteLine();

                if ((teclas.Key == ConsoleKey.F) &&
                    ((teclas.Modifiers & ConsoleModifiers.Control) != 0))
                {
                    break;
                }

            } while (true);



        }
    }
}
