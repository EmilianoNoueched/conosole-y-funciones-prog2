using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BancoDeMentira.Clases;

namespace BancoDeMentira
{
    class Program
    {


        static void Main(string[] args)
        {
            //Crear clase program CuentaBancaria con los siguientes atributos:
            //Num movimientos
            //Titular
            //Saldo
            //Numero
            //Pin
            //Hacer funcion depositar que solo modifique el saldo osea lo aumenta 
            //otra que se llame extraer que lo disminuya controlando no pasarse del saldo que tengo



            short numCuenta;
            string titular;
            short saldo;
            short numero;
            short pin;

            Console.WriteLine("Ingrese numero de cuenta: ");
            numCuenta = short.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese titular: ");
            titular = Console.ReadLine();

            Console.WriteLine("Ingrese saldo: ");
            saldo = short.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese numero: ");
            numero = short.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese pin: ");
            pin = short.Parse(Console.ReadLine());



            CuentaBancaria nuevaCuentaBancaria = new CuentaBancaria(numCuenta, titular, saldo, numero, pin);

            nuevaCuentaBancaria.Setpin(1234);

            Console.WriteLine("**************** Datos de la nueva cuenta ******************");
            Console.WriteLine("numCuenta: " + nuevaCuentaBancaria.GetnumCuenta());
            Console.WriteLine("titular: " + nuevaCuentaBancaria.Gettitular());
            Console.WriteLine("saldo: " + nuevaCuentaBancaria.Getsaldo());
            Console.WriteLine("pin: " + nuevaCuentaBancaria.Getpin());
            Console.WriteLine("numero: " + nuevaCuentaBancaria.Getnumero());
            Console.WriteLine(nuevaCuentaBancaria.depositar(100));
            Console.WriteLine(nuevaCuentaBancaria.extraer(500));
            Console.ReadKey();


        }

    }
}

    

