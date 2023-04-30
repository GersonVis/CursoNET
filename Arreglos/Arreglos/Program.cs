using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arreglos
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros;
            string[] nombres;

            int[] inicializar = new int[4] { 1, 2, 3, 4 };
            int[] inicializarDos = { 1, 2, 3, 4 };
            var inicializarImplicita = new[] { 1, 2, 3 };

            int[] edades = { 12, 34, 22, 80, 63 };
            for (int i = 0; i < edades.Length; i++) {
                var valorArray = edades[i];
            }

            foreach (int elemento in edades) {
                Console.WriteLine(elemento);
            }


            int[] arreglo = { 1, 2, 3, 4, 5, 6 };
            int[] arregloCopia = (int[])arreglo.Clone();

            Array.Copy(arreglo, arregloCopia, arreglo.Length);


            int[,] arrayBidimensional = { { 1, 2 }, { 3, 3 } };

            paramsEjemplo(3, 4, 5, 3, 4, 5);
        }
        public static void paramsEjemplo(params int[] parametros) {
            foreach (int parametro in parametros) {
                Console.WriteLine(parametro);
            }
        }
    }
}
