using CAPoliza.Aplicacion.SQLsAplicacion;
using CAPoliza.Aplicacion.MDbAplicacion;
using CAPoliza.Dominios;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PolizaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PolizaController : ControllerBase
    {
        private readonly IServicioPoliza _servicio;

        private readonly IMDBServicioPoliza _MDBservicio;

        public PolizaController(IServicioPoliza servicio, IMDBServicioPoliza mDBServicioPoliza)
        {
            _servicio = servicio;

            _MDBservicio = mDBServicioPoliza;
        }


        // GET: api/<PolizaController>
        [HttpGet]
        public ActionResult<List<Poliza>> Get()
        {
            var PolizaServicio = _servicio.GetAllPolizas();
            return Ok(PolizaServicio);

        }

        [HttpPost]
        public ActionResult<Poliza> PostPoliza(Poliza poliza)
        {
            try
            {
                var PolizaCreacion = _servicio.CreatePoliza(poliza);
                return Ok(poliza);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

        [HttpGet("PolizaPorPlacaOnumero")]
        public async Task<ActionResult<List<Poliza>>> PolizaPorPlacaOnumero(int? IdPoliza = null, string? PlacaAuto = null)
        {
            var polizasServicio = await _servicio.PolizaPorPlacaOnumero(IdPoliza, PlacaAuto);
            return Ok(polizasServicio);
        }



        [HttpGet("MGDBAllPolizas")]
        public ActionResult<List<MDBPoliza>> MDBGet()
        {
            var PolizaServicio = _MDBservicio.GetAllPolizas();
            return Ok(PolizaServicio);

        }


        [HttpPost("MGDBCreatePolizas")]
        public ActionResult<MDBPoliza> MDBPostPoliza(MDBPoliza poliza)
        {
            try
            {
                var PolizaCreacion = _MDBservicio.CreatePoliza(poliza);
                return Ok(poliza);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        [HttpGet("MDBPolizaPorPlacaOnumero")]
        public async Task<ActionResult<List<MDBPoliza>>> MDBPolizaPorPlacaOnumero(int? IdPoliza = null, string? PlacaAuto = null)
        {
            var polizasServicio = await _MDBservicio.PolizaPorPlacaOnumero(IdPoliza, PlacaAuto);
            return Ok(polizasServicio);
        }

    }
}
