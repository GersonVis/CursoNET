using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepsiones
{
    class Program
    {
        static void Main(string[] args)
        {
            // para revisar si ocurre una excepsion en una operacion aritmetica
            // se uliza la palabra reservada checked
            // si se sobre pasa el máximo númeor de un tipo de dato
            // este regresa a su valor negativo más elejado
            exceptionPropia("error creado por el usuario");
            int valor = int.MaxValue;
            //no generá ningúna excepsion
            valor++;
            valor--;
            // si genera una excepsion
            checked {
                valor++;
            }
            Console.WriteLine(valor);
            Console.ReadKey();

            //otra forma de checar valores
        }
        // genera excepsiones
        static void checkedForma1() {
            int valor = int.MaxValue;
            valor = checked(valor++);
        }
        // no genera excepsiones
        static void noCheckar() {
            int valor = int.MaxValue;
            valor = unchecked(valor++);
        }
        static void exceptionPropia(string msg) {
            try
            {
                throw new InvalidOperationException(msg);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally {
                Console.WriteLine("estamos en finally");
            }
            Console.WriteLine("ejecutado");
            
        }
    }
}
