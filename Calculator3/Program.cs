using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator3
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            
            do
            {
                Console.WriteLine("Escriba numero a calcular (use +, -, * o / ): ");
                Console.WriteLine("Escriba (Ej. '10 + 5 * 2') : ");
                input = Console.ReadLine();


                //eliminar los espacios
                input = input.Replace(" ", "");
                //resolver todo
                try
                {
                    var result = new DataTable().Compute(input, "") + "";
                    Console.WriteLine(result);
                }
                catch (Exception exc)
                {
                    Console.WriteLine("Solo puedes escribir en este rango de caracteres");
                    Console.WriteLine("0-9, '+,-,/,*' y usar parentesis");
                }
            } while (input != "salir");
        }
    }
}
