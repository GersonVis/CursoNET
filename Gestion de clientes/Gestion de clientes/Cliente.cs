﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_de_clientes
{
    class Cliente
    {
        public string Nombre{
            get;
            set;
       }
        public string Apellido {
            get;
            set;
        }
        public string NumeroTelefono {
            get;
            set;
        }
        public string NombreCompleto
        {
            get { return Nombre + " " + Apellido; }
        }

        public override string ToString()
        {
            return NombreCompleto;
        }
    }
}
