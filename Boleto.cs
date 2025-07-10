using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Vuelos.Clases
{
    public class Boleto
    {
        public int IdBoleto { get; set; }
        public int IdPasajero { get; set; }
        public int IdVuelo { get; set; }
        public int IdAsiento { get; set; }
        public DateTime FechaCompra { get; set; }
        public decimal PrecioTotal { get; set; }
    }
}
