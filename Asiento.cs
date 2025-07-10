using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Vuelos.Clases
{
    public class Asiento
    {
        public int IdAsiento { get; set; }
        public int IdVuelo { get; set; }
        public string NumeroAsiento { get; set; }
        public bool Ocupado { get; set; }
    }
}
