using CAPoliza.Aplicacion.SQLsAplicacion;
using CAPoliza.Dominios;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPoliza.Infraestructura.SQLsInfraestructura
{
    public class RepositorioPoliza : IRepositorioPoliza
    {
        public static List<Poliza> polizas = new List<Poliza>() {

            new Poliza(){
                id =1,
                NombreCliente = "Sebastian",
                IdentificacionCliente = "123345234",
                FechaNacimientoCliente = DateTime.Parse("28/12/1991"),
                FechaPoliza = DateTime.Parse("3/8/2019"),
                CoberturasCubiertas = 4,
                ValorMaxPoliza = 500000,
                NombrePlanPoliza = "Obligatoria",
                CiudadResideCliente = "Bogotá",
                DireccionCliente = "Cra 127 # 55-08",
                PlacaAuto = "BLU191",
                Inspeccion = true
            },

            new Poliza(){
                id =2,
                NombreCliente = "Andres",
                IdentificacionCliente = "234234",
                FechaNacimientoCliente = DateTime.Parse("10/5/1982"),
                FechaPoliza = DateTime.Parse("4/7/2022"),
                CoberturasCubiertas = 1,
                ValorMaxPoliza = 2000000,
                NombrePlanPoliza = "Todoriesgo",
                CiudadResideCliente = "Cali",
                DireccionCliente = "Cra 22 # 11-51",
                PlacaAuto = "ARE034",
                Inspeccion = false  },

            new Poliza(){
                id =3,
                NombreCliente = "Luisa",
                IdentificacionCliente = "546745674567",
                FechaNacimientoCliente = DateTime.Parse("11/1/1963"),
                FechaPoliza = DateTime.Parse("4/7/2022"),
                CoberturasCubiertas = 1,
                ValorMaxPoliza = 500000,
                NombrePlanPoliza = "Obligatoria",
                CiudadResideCliente = "Medellin",
                DireccionCliente = "Cll 71 # 11-51",
                PlacaAuto = "SAS233",
                Inspeccion = false  },


            new Poliza(){
                id =4,
                NombreCliente = "Camila",
                IdentificacionCliente = "8567567567",
                FechaNacimientoCliente = DateTime.Parse("31/07/1994"),
                FechaPoliza = DateTime.Parse("22/10/2022"),
                CoberturasCubiertas = 1,
                ValorMaxPoliza = 2000000,
                NombrePlanPoliza = "Todoriesgo",
                CiudadResideCliente = "Bogotá",
                DireccionCliente = "Av 37 # 11B-21",
                PlacaAuto = "MIO123",
                Inspeccion = false
            }

        };

        private readonly PolizaDBcontext _polizaDBcontext;

        public RepositorioPoliza(PolizaDBcontext polizaDBcontext)
        {
            _polizaDBcontext = polizaDBcontext;
        }

        public Poliza CreatePoliza(Poliza poliza)
        {
            _polizaDBcontext.Polizas.Add(poliza);
            _polizaDBcontext.SaveChanges();
            return poliza;
        }

        List<Poliza> IRepositorioPoliza.GetAllPolizas()
        {
            //para el ejemplo desede la infraestructura
            //return polizas; 

            return _polizaDBcontext.Polizas.ToList();

        }

        public async Task<List<Poliza>> PolizaPorPlacaOnumero(int? IdPoliza = null, string? PlacaAuto = null)
        {
            var ConsultaPoliza = _polizaDBcontext.Polizas.AsQueryable();

            if (IdPoliza != null)
            {
                ConsultaPoliza = ConsultaPoliza.Where(e => e.id == IdPoliza);
            }

            if (!string.IsNullOrEmpty(PlacaAuto))
            {
                ConsultaPoliza = ConsultaPoliza.Where(e => e.PlacaAuto == PlacaAuto);
            }

            return await ConsultaPoliza.ToListAsync();
        }


    }
}
