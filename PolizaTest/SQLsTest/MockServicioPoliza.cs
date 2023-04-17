using CAPoliza.Aplicacion.SQLsAplicacion;
using CAPoliza.Dominios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolizaTest.SQLsTest
{
    public class MockServicioPoliza : IServicioPoliza
    {
        private readonly List<Poliza> _polizas = new List<Poliza>();

        public List<Poliza> GetAllPolizas()
        {
            return _polizas;
        }

        public Task<List<Poliza>> PolizaPorPlacaOnumero(int? IdPoliza = null, string? PlacaAuto = null)
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

        public Poliza CreatePoliza(Poliza poliza)
        {
            _polizas.Add(poliza);
            return poliza;
        }

    }
}
