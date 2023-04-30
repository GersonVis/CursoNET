using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumeraciones
{
    class Program
    {
        static void Main(string[] args)
        {
            Rol rolUsuario = Rol.Administrador;
            switch (rolUsuario) { 
               case Rol.Administrador:
                    Console.WriteLine("eres administrador");
                    break;
            }
            rolUsuario++;
            rolUsuario += 20;
        }
    }
}
