using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesDemo1
{
    class Circulo
    {
        // propiedad compartida por todas los objetos que lo heredan
        public static int numeroCirculos = 0;
        int radio;

        //propiedad constante, solo se puede tener acceso a su valor
        public const double PI = 3.1416;
        public Circulo() {
            
            numeroCirculos++;
        }
    }
}
