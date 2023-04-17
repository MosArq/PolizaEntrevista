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
            if (Vigencia(poliza))
            {
                throw new Exception("La poliza que se desea crear no es vigente");
            }

            _mdbrepositorioPoliza.CreatePoliza(poliza);
            return poliza;
        }

        public async Task<List<MDBPoliza>> PolizaPorPlacaOnumero(int? IdPoliza = null, string? PlacaAuto = null)
        {
            return await _mdbrepositorioPoliza.PolizaPorPlacaOnumero(IdPoliza, PlacaAuto);
        }


        #region Regla de negocio
        public bool Vigencia(MDBPoliza poliza)
        {
            DateTime Hoy = DateTime.Today;

            return poliza.FechaInicialPoliza < Hoy || poliza.FechaFinalPoliza < Hoy;
        }
        #endregion
    }
}
