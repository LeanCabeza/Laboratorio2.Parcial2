using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;

namespace UnitTest
{
    [TestClass]
    public class PruebaUnitaria
    {

        [TestClass]
        public class Tests
        {
            [TestMethod]
            public void CrearComida()
            {
                Comida testComida = new Comida("Fideos con tuco",ETipo.ComidaGurmet, 300);

                Assert.IsNotNull(testComida);

            }

            [TestMethod]
            public void GuardarTxt()
            {
                Comida comidaPrueba = new Comida("Ñoquis",ETipo.ComidaGurmet,500);

                bool retorno = GuardaString.Guardar(comidaPrueba);

                Assert.IsTrue(retorno);
            }
        }
    }
}
