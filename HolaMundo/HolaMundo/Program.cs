using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolaMundo
{
    class Program
    {
        static string nombre = "gerson";
        static void Main(string[] args)
        {
            int prueba = 3;
            prueba *= prueba;
            Console.Write(prueba);
            imprimirNombre();
            cambiarNombre();
            imprimirNombre();

            argumentosConNombre(argumentoUno: "gerson", 34);
            argumentosConNombre(edad: 34, argumentoUno: "perro");

            Console.ReadKey();
        }
        static void imprimirNombre() {
            Console.Write(nombre);
        }
        static void cambiarNombre() {
            nombre = "cambiado";
        }
        static void argumentosConNombre(string argumentoUno = "", int edad = 24) {

            Console.WriteLine(argumentoUno);
            Console.WriteLine(edad);
        }


        static void 
    }
}
