using CAPoliza.Dominios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPoliza.Aplicacion.SQLsAplicacion
{
    public class ServicioPoliza : IServicioPoliza
    {
        private readonly IRepositorioPoliza _repositorioPoliza;

        public ServicioPoliza(IRepositorioPoliza repositorioPoliza)
        {
            _repositorioPoliza = repositorioPoliza;
        }

        public Poliza CreatePoliza(Poliza poliza)
        {
            if (Vigencia(poliza))
            {
                throw new Exception("La poliza que se desea crear no es vigente");
            }

            _repositorioPoliza.CreatePoliza(poliza);
            return poliza;
        }

        public List<Poliza> GetAllPolizas()
        {
            var poliza = _repositorioPoliza.GetAllPolizas();

            return poliza;
        }

        public bool Vigencia(Poliza poliza)
        {
            DateTime Hoy = DateTime.Today;

            return poliza.FechaInicialPoliza < Hoy || poliza.FechaFinalPoliza < Hoy;
        }

        public async Task<List<Poliza>> PolizaPorPlacaOnumero(int? IdPoliza = null, string? PlacaAuto = null)
        {
            return await _repositorioPoliza.PolizaPorPlacaOnumero(IdPoliza, PlacaAuto);
        }



    }
}
