using CAPoliza.Aplicacion.MDbAplicacion;
using CAPoliza.Dominios;
using MongoDB.Driver;
using MongoDB.Driver.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPoliza.Infraestructura.MDbModel
{
    public class MDBRepositorioPoliza: IMDBRepositorioPoliza
    {
        private IMongoCollection<MDBPoliza> _poliza;

        public MDBRepositorioPoliza(IBarSettings settings)
        {
            var cliente = new MongoClient(settings.Server);
            var database = cliente.GetDatabase(settings.Database);
            _poliza = database.GetCollection<MDBPoliza>(settings.Collection);
        }

        public List<MDBPoliza> GetAllPolizas()
        {
            return _poliza.Find(d => true).ToList();
        }

        public MDBPoliza CreatePoliza(MDBPoliza poliza)
        {
            _poliza.InsertOne(poliza);
            return poliza;
        }

        public async Task<List<MDBPoliza>> PolizaPorPlacaOnumero(int? IdPoliza = null, string? PlacaAuto = null)
        {
            var builder = Builders<MDBPoliza>.Filter;
            var filter = builder.Empty;

            if (IdPoliza != null)
            {
                filter = filter & builder.Eq(p => p.id, IdPoliza);
            }

            if (!string.IsNullOrEmpty(PlacaAuto))
            {
                filter = filter & builder.Eq(p => p.PlacaAuto, PlacaAuto);
            }

            var result = await _poliza.Find(filter).ToListAsync();
            return result;
        }



    }
}
