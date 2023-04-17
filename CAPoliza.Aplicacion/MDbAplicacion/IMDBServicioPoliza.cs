using CAPoliza.Dominios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPoliza.Aplicacion.MDbAplicacion
{
    public interface IMDBServicioPoliza
    {
        List<MDBPoliza> GetAllPolizas();

        MDBPoliza CreatePoliza(MDBPoliza poliza);

        Task<List<MDBPoliza>> PolizaPorPlacaOnumero(int? IdPoliza = null, string? PlacaAuto = null);
    }
}
