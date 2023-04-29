using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiposValorTiposReferencia
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             si una variable no es inicializada esta variable
             el valor de  esta variable es null
             */
            Circulo cir = new Circulo();
            
            if (cir != null) {
                Console.WriteLine(Circulo.RADIO); 
            }

            // solo ejecutar si el objeto no es nulo, de manera simplificada
            Console.WriteLine(cir?.radio);


            // para asignar null a una variable o que en algún momento puede
            // ser nulo 
            int? puedeSerNullo = null;

            // para conversión entre tipos de datos ambos deben ser
            // posiblemente nulos
            int? pasarValor = 0;
            pasarValor = puedeSerNullo;

            //saber si la variable es nula
            if (!puedeSerNullo.HasValue) {
                // si es nulo entra
                puedeSerNullo = 0;
            }

            int numero = 0;
            metodoReferencia(ref numero);

            int noInicializada;
            metodoOut(out noInicializada);

            int.TryParse("34", out int valorEnCadena);

            object numeroInt = 12;
            object texto = "informacion";

            int numeroRecuperado = (int)numeroInt;
            string textoRecuperado = (string)texto;

            object numeroObjecto = 2;
            int? contenedorNumero = numeroObjecto as int?;


        }
        public static void metodoOut(out int variable) {
            variable = 0;
        }
        public static void sinRefencia(int recivirVariable) { 

        }

        public static void metodoReferencia(ref int variableReferenciada) { 
        
        }
    }
}
