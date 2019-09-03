using IntroPOO.Clases;
using System;

namespace IntroPOO
{
    class Program
    {
        static void Main(string[] args)
        {

            Persona nuevaPersona;

            string nombre;
            string apellido;
            string cedula;
            short edad;
            short altura;

            Console.WriteLine("Ingrese Nombre: ");
            nombre = Console.ReadLine();

            Console.WriteLine("Ingrese Apellido: ");
            apellido = Console.ReadLine();

            Console.WriteLine("Ingrese Cedula: ");
            cedula = Console.ReadLine();

            Console.WriteLine("Ingrese Edad: ");
            edad = short.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese Altura: ");
            altura = short.Parse(Console.ReadLine());



            nuevaPersona = new Persona(cedula,nombre,apellido, edad,altura);

            nuevaPersona.SetEdad(-100);

            Console.WriteLine("**************** Datos de la nueva Persona ******************");
            Console.WriteLine("Nombre: " + nuevaPersona.nombre);
            Console.WriteLine("Apellido: " + nuevaPersona.apellido);
            Console.WriteLine("Cédula: " + nuevaPersona.cedula);
            Console.WriteLine("Edad: " + nuevaPersona.GetEdad());
            Console.WriteLine("Altura: " + nuevaPersona.altura);
            Console.ReadKey();

  


        }
    }
}
