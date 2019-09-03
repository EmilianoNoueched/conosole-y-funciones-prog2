using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPrimerConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            string valorUsuario;
            Console.WriteLine("Ingrese su nombre: ");
            valorUsuario = Console.ReadLine();

            string respuesta = "Hola, " + valorUsuario;
            Console.WriteLine(respuesta);

            Console.WriteLine("Ingrese el número 1: ");
            string strNum1 = Console.ReadLine();
            int num1 = int.Parse(strNum1);

            Console.WriteLine("Ingrese el número 2: ");
            string strNum2 = Console.ReadLine();
            int num2 = int.Parse(strNum2);

   
            int rest = suma(num1, num2);
            int rest1 = suma(7, 100);

            mostrarResultado(rest);

            Console.ReadKey();
        }

        static int suma(int n1, int n2)
        {
            if (n1 < 0 || n2 < 0)
            {
                return 0;
            }

            int rest = n1 + n2;
            return rest;
        }

        static void mostrarResultado(int resultado)
        {
            Console.WriteLine("El resultado de la suma es: ");
            Console.WriteLine(resultado);
            Console.WriteLine("Gracias por usar mi primer consola.");
        }

    }
}
