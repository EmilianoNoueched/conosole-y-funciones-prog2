using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using introPOO.clases;

namespace introPOO
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

            
            Console.WriteLine("Ingrese cedula: ");
            cedula = Console.ReadLine();

            
            Console.WriteLine("Ingrese nombre: ");
            nombre = Console.ReadLine();

            
            Console.WriteLine("Ingrese apellido: ");
            apellido = Console.ReadLine();

             
            Console.WriteLine("Ingrese edad: ");
            edad = short.Parse(Console.ReadLine());

            
            Console.WriteLine("Ingrese altura: ");
            altura = short.Parse(Console.ReadLine());

            nuevaPersona= new Persona(cedula, nombre, apellido, edad, altura);  //aca se crea realmente el obj.  el persona luego del new es un constructor.

            nuevaPersona.SetEdad(-100);


            Console.WriteLine("******************* ESTA ES LA NUEVA PERSONA ************** ");
            Console.WriteLine(" El nombre: " + nuevaPersona.nombre);
            Console.WriteLine(" El Apellido: " + nuevaPersona.apellido);
            Console.WriteLine(" La cedula: " + nuevaPersona.cedula);
            Console.WriteLine(" La altura: " + nuevaPersona.altura);
            Console.WriteLine(" La edad: " + nuevaPersona.GetEdad());
            Console.ReadKey();


        }
    }
}
