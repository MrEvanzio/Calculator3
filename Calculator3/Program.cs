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
            int suma;

            Console.WriteLine("Escriba 2 Numeros a sumar: ");
            Console.WriteLine("Escriba 1er Numero : ");
            suma = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Escriba 2do Numero : ");
            suma = suma + Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("La suma de ambos numeros es : " + suma);

        }
    }
}
