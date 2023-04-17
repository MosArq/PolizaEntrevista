using CAPoliza.Aplicacion.MDbAplicacion;
using CAPoliza.Dominios;

namespace PolizaTest.MDBTest
{
    public class MockMDBServicioPoliza: IMDBServicioPoliza
    {
        private readonly List<MDBPoliza> _polizas = new List<MDBPoliza>();

        public List<MDBPoliza> GetAllPolizas()
        {
            return _polizas;
        }

        public Task<List<MDBPoliza>> PolizaPorPlacaOnumero(int? IdPoliza = null, string? PlacaAuto = null)
        {
            var query = _polizas.AsQueryable();

            if (IdPoliza.HasValue)
            {
                query = query.Where(p => p.id == IdPoliza.Value);
            }

            if (!string.IsNullOrEmpty(PlacaAuto))
            {
                query = query.Where(p => p.PlacaAuto == PlacaAuto);
            }

            return Task.FromResult(query.ToList());
        }

        public MDBPoliza CreatePoliza(MDBPoliza poliza)
        {
            _polizas.Add(poliza);
            return poliza;
        }
    }
}
