using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condiciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un numero para la condicion.");
            int numeroIngresado = int.Parse(Console.ReadLine());
            if (numeroIngresado == 7)
                Console.WriteLine("este numero es: 7.");
            else if (numeroIngresado < 0)
                Console.WriteLine("Este Numero Es Negativo");
            else
                Console.WriteLine("No es ninguno de los valores permitidos.");
            Console.ReadLine();




        }
    }
}
