using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesAbstractas
{
    class Program
    {
        static void Main(string[] args)
        {
            

            
            Linea linea = new Linea();


            //implmenta lo declarado en circulo
            IFigura figura = new Circulo();
            //implementa lo declarado en linea
            IFigura figura2 = new Linea();

            figura.Dibujar();

            Circulo circulo = new Circulo();

            IFigura circuloFigura = circulo;
            circuloFigura.Dibujar();

            IRenderizar circuloRenderizar = circulo;
            circuloRenderizar.Dibujar();


            linea.Dibujar();
        }
    }

}
