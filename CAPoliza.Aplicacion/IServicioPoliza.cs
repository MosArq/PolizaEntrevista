using CAPoliza.Dominios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPoliza.Aplicacion
{
    public interface IServicioPoliza
    {
        List<Poliza> GetAllPolizas();

        Poliza CreatePoliza(Poliza poliza);

        Task<List<Poliza>> PolizaPorPlacaOnumero(int? IdPoliza = null, string? PlacaAuto = null);
    }
}
