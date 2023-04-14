using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPoliza.Dominios
{
    public class Poliza
    {
        public int id { get; set; }
        public string NombreCliente { get; set; } = string.Empty;

        public string IdentificacionCliente { get; set; } = string.Empty;

        public DateTime FechaNacimientoCliente { get; set; }

        public DateTime FechaPoliza { get; set; }

        public int CoberturasCubiertas { get; set; }

        public decimal ValorMaxPoliza { get; set; }

        public string NombrePlanPoliza { get; set; } = string.Empty;

        public string CiudadResideCliente { get; set; } = string.Empty;

        public string DireccionCliente { get; set; } = string.Empty;

        public string PlacaAuto { get; set; } = string.Empty;

        public bool Inspeccion { get; set; }

        public DateTime FechaInicialPoliza { get; set; }

        public DateTime FechaFinalPoliza { get; set; }
    }
}
