using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesDemo1
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangulo rectangulo = new Rectangulo(10, 23);
            rectangulo.calcularArea();

            (var baseRect, var color) = rectangulo;

            //los metodos estaticos solo pueden ser llamados desde la clase principal
            Rectangulo.calcularArea(10, 30);


           
            
            Console.WriteLine(baseRect + " " + color);


            Circulo cir = new Circulo();
            Circulo cir2 = new Circulo();
            Circulo cir3 = new Circulo();
            Circulo cir4 = new Circulo();

            //objeto anonimo
            var objetoAnonimo = new {
                nombre = "gerson"
            };
            var t = objetoAnonimo.nombre;

            Console.WriteLine("Número de circulos: "+Circulo.numeroCirculos);
            Console.ReadKey();
        }
    }
}
