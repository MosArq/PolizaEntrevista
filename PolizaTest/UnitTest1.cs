using CAPoliza.Dominios;


namespace PolizaTest
{
    [TestClass]
    public class MockServicioPolizaTest
    {
        private readonly MockServicioPoliza _servicio;

        public MockServicioPolizaTest()
        {
            _servicio = new MockServicioPoliza();
        }

        [TestMethod]
        public void GetAllPolizas_Cuandonohaypolizas()
        {
            // Acto
            var result = _servicio.GetAllPolizas();

            // Resultado
            Assert.IsNotNull(result);
            Assert.AreEqual(0, result.Count);
        }

        [TestMethod]
        public void GetAllPolizas_CuandoExistanPolizas()
        {
            // Ingreso
            var poliza = new Poliza { id = 1, PlacaAuto = "ABC123" };
            _servicio.CreatePoliza(poliza);

            // Acto
            var result = _servicio.GetAllPolizas();

            // Resultado
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.Count);
            Assert.AreEqual(poliza.id, result[0].id);
            Assert.AreEqual(poliza.PlacaAuto, result[0].PlacaAuto);
        }

        [TestMethod]
        public void PolizaPorPlacaOnumero_Cuandonoencuentrelaplaca()
        {
            // Acto
            var result = _servicio.PolizaPorPlacaOnumero(PlacaAuto: "XYZ789");

            // Resultado
            Assert.IsNotNull(result);
            Assert.AreEqual(0, result.Result.Count);
        }

        [TestMethod]
        public void PolizaPorPlacaOnumero_cuandolaplacaexista()
        {
            // Ingreso
            var poliza1 = new Poliza { id = 1, PlacaAuto = "ABC123" };
            _servicio.CreatePoliza(poliza1);

            var poliza2 = new Poliza { id = 2, PlacaAuto = "DEF456" };
            _servicio.CreatePoliza(poliza2);

            // Acto
            var result = _servicio.PolizaPorPlacaOnumero(PlacaAuto: "ABC123");

            // Resultado
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.Result.Count);
            Assert.AreEqual(poliza1.id, result.Result[0].id);
            Assert.AreEqual(poliza1.PlacaAuto, result.Result[0].PlacaAuto);
        }

        [TestMethod]
        public void CreatePoliza_Agregarlapoliza()
        {
            // Ingreso
            var poliza = new Poliza { id = 1, PlacaAuto = "ABC123" };

            // Acto
            var result = _servicio.CreatePoliza(poliza);

            // Resultado
            Assert.IsNotNull(result);
            Assert.AreEqual(poliza.id, result.id);
            Assert.AreEqual(poliza.PlacaAuto, result.PlacaAuto);

            var getAllResult = _servicio.GetAllPolizas();
            Assert.IsNotNull(getAllResult);
            Assert.AreEqual(1, getAllResult.Count);
            Assert.AreEqual(poliza.id, getAllResult[0].id);
            Assert.AreEqual(poliza.PlacaAuto, getAllResult[0].PlacaAuto);
        }
    }
}