using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos
{
    internal class LeerTeclado
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Porfavor ingresa el primer numero para realizar una suma: ");
            string numeroIngresado = Console.ReadLine();
            int num1 = int.Parse(numeroIngresado);
            Console.WriteLine("Porfavor ingresa el segundo numero para realizar una suma: ");
            string segundoNumeroIngresado = Console.ReadLine();
            int num2 = int.Parse(segundoNumeroIngresado);
            int resultado = num1 + num2;
            Console.WriteLine("El resultados de la suma de {0} + {1} es de: {2}", num1, num2, resultado);
            Console.ReadLine();

        }
    }
}
