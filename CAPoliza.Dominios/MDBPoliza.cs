using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPoliza.Dominios
{
    public class MDBPoliza
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string _id { get; set; }

        [BsonElement("id")]
        public int id { get; set; }

        [BsonElement("NombreCliente")]
        public string NombreCliente { get; set; } = string.Empty;

        [BsonElement("IdentificacionCliente")]
        public string IdentificacionCliente { get; set; } = string.Empty;

        [BsonElement("FechaNacimientoCliente")]
        public DateTime FechaNacimientoCliente { get; set; }

        [BsonElement("FechaPoliza")]
        public DateTime FechaPoliza { get; set; }

        [BsonElement("CoberturasCubiertas")]
        public int CoberturasCubiertas { get; set; }

        [BsonElement("ValorMaxPoliza")]
        public decimal ValorMaxPoliza { get; set; }

        [BsonElement("NombrePlanPoliza")]
        public string NombrePlanPoliza { get; set; } = string.Empty;

        [BsonElement("CiudadResideCliente")]
        public string CiudadResideCliente { get; set; } = string.Empty;

        [BsonElement("DireccionCliente")]
        public string DireccionCliente { get; set; } = string.Empty;

        [BsonElement("PlacaAuto")]
        public string PlacaAuto { get; set; } = string.Empty;

        [BsonElement("Inspeccion")]
        public bool Inspeccion { get; set; }

        [BsonElement("FechaInicialPoliza")]
        public DateTime FechaInicialPoliza { get; set; }

        [BsonElement("FechaFinalPoliza")]
        public DateTime FechaFinalPoliza { get; set; }

    }
}
