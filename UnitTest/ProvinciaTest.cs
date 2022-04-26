using Flock.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    [TestClass]
    public class ProvinciaTest
    {
        private LocationController controller;

        [TestInitialize]
        public void Init()
        {
            controller = new LocationController();
        }

        [TestMethod]
        public void Valido_ProvinciaChubut()
        {
            var nombreProv = "Chubut";

            var result = controller.GetLocation(nombreProv);

            Assert.IsTrue(result.Type == "OK");
        }

        [TestMethod]
        public void Valido_ProvinciaNoExiste()
        {
            var nombreProv = "Aasdasdasd";

            var result = controller.GetLocation(nombreProv);

            Assert.IsTrue(result.Type == "Error" && result.Message == "No se encontraron provincias");
        }

        [TestMethod]
        public void Valido_ProvinciaVacio()
        {
            var nombreProv = "";

            var result = controller.GetLocation(nombreProv);

            Assert.IsTrue(result.Type == "Error");
        }
    }
}
