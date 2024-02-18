using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos
{
    internal class EntradaSalida
    {
        static void Main(string[] args)
        {
            string nombre;
            Console.WriteLine("Escribe tu nombre Porfavor: ");
            nombre = Console.ReadLine();
            Console.WriteLine("¿Hola como estas? --- " +nombre  );
            Console.ReadLine();
        }
    }
}
