using System;
using System.Collections.Generic;
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
            string multNumber1 = "";
            string multNumber2 = "";
            int tempResul = 0;
            int count = 0;


            Console.WriteLine("Escriba numero a calcular (use +, -, * o / ): ");
            Console.WriteLine("Escriba (Ej. '10 + 5 * 2') : ");
            input = Console.ReadLine();


            //eliminar los espacios
            Console.WriteLine(input);
            input = input.Replace(" ", "");
            int cantChar = input.Length;
            //checkear por parentesis
            //Exponentes
            //Multiplicaciones y Divisiones
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '*')
                {
                    int cant = i - 1;
                    while (Char.IsDigit(input[cant]))
                    {
                        Console.WriteLine(input[cant]);
                        multNumber1 = Convert.ToString(input[cant]) + multNumber1;
                        cant--;
                    }
                    cant = i + 1;
                    while (Char.IsDigit(input[cant]))
                    {
                        Console.WriteLine(input[cant]);
                        multNumber2 = Convert.ToString(input[cant]) + multNumber2;
                        cant++;
                    }
                }
            }

            Console.WriteLine(multNumber1 + " + " + multNumber2);
            //Sumas y Restas
        }
    }
}
