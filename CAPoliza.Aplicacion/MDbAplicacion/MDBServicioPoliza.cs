using CAPoliza.Aplicacion.SQLsAplicacion;
using CAPoliza.Dominios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPoliza.Aplicacion.MDbAplicacion
{
    public class MDBServicioPoliza : IMDBServicioPoliza
    {
        private readonly IMDBRepositorioPoliza _mdbrepositorioPoliza;

        public MDBServicioPoliza(IMDBRepositorioPoliza mdbrepositorioPoliza)
        {
            _mdbrepositorioPoliza = mdbrepositorioPoliza;
        }

        public List<MDBPoliza> GetAllPolizas()
        {
            return _mdbrepositorioPoliza.GetAllPolizas();
        }

        public MDBPoliza CreatePoliza(MDBPoliza poliza)
        {
            throw new NotImplementedException();
        }

        public Task<List<MDBPoliza>> PolizaPorPlacaOnumero(int? IdPoliza = null, string? PlacaAuto = null)
        {
            throw new NotImplementedException();
        }
    }
}
