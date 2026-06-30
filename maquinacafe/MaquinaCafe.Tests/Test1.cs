using Microsoft.VisualStudio.TestTools.UnitTesting;
using MaquinaCafe;

namespace MaquinaCafe.Tests
{
    [TestClass]
    public class CafeTests
    {

        [TestMethod]
        public void VasoPequenoDebeTener3Oz()
        {
            MaquinaCafe maquina = new MaquinaCafe();

            Cafe cafe = maquina.PrepararCafe("Pequeno", 1);

            Assert.AreEqual(3, cafe.Oz);
        }


        [TestMethod]
        public void VasoMedianoDebeTener5Oz()
        {
            MaquinaCafe maquina = new MaquinaCafe();

            Cafe cafe = maquina.PrepararCafe("Mediano", 2);

            Assert.AreEqual(5, cafe.Oz);
        }


        [TestMethod]
        public void VasoGrandeDebeTener7Oz()
        {
            MaquinaCafe maquina = new MaquinaCafe();

            Cafe cafe = maquina.PrepararCafe("Grande", 3);

            Assert.AreEqual(7, cafe.Oz);
        }


        [TestMethod]
        public void DebeGuardarCantidadDeAzucar()
        {
            MaquinaCafe maquina = new MaquinaCafe();

            Cafe cafe = maquina.PrepararCafe("Pequeno", 2);

            Assert.AreEqual(2, cafe.Azucar);
        }


        [TestMethod]
        public void DebeMostrarMensajeSiNoHayVasos()
        {
            MaquinaCafe maquina = new MaquinaCafe();

            maquina.Vasos = 0;

            Cafe cafe = maquina.PrepararCafe("Pequeno", 1);

            Assert.AreEqual("No existen vasos disponibles", cafe.Mensaje);
        }


        [TestMethod]
        public void DebeMostrarMensajeSiNoHayCafe()
        {
            MaquinaCafe maquina = new MaquinaCafe();

            maquina.CafeDisponible = false;

            Cafe cafe = maquina.PrepararCafe("Grande", 1);

            Assert.AreEqual("No existe cafe disponible", cafe.Mensaje);
        }

    }
}