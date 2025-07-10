using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaPasajeros
{
    internal class Vuelos
    {
        public int IdVuelo { get; set; }
        public string Origen { get; set; }
        public string Destino { get; set; }
        public DateTime FechaSalida { get; set; }
        public TimeSpan HoraSalida { get; set; }
        public int IdAsiento { get; set; }
        public string NumeroAsiento { get; set; }
        public int IdPasajero { get; set; }
        public string Nombre { get; set; }
        public int IdBoleto { get; set; }
        public string CodigoBarra { get; set; }
        public bool Llego { get; set; }
        public string Ruta => $"{Origen} → {Destino}";

    }
}
