using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vsite.Pood;

namespace Testovi
{
    [TestClass]
    public class TestPrimBrojeva
    {
        [TestMethod]
        public void GenerirajPrimBrojeveVraćaPrazanNizZa0()
        {
            Assert.AreEqual(0, Program.GenerirajPrimBrojeve(0).Length);
        }

        [TestMethod]
        public void GenerirajPrimBrojeveVraćaPrazniNizZa1()
        {
            Assert.AreEqual(0, Program.GenerirajPrimBrojeve(1).Length);
        }

        [TestMethod]
        public void GenerirajPrimBrojeveVraćaPrazniNizZa2()
        {
            Assert.AreEqual(1, Program.GenerirajPrimBrojeve(2).Length);
        }

        [TestMethod]
        public void GenerirajPrimBrojeveVraćaNizKojiSadrži25PrimBrojevaZaArgument100()
        {
            var primbrojevi = Program.GenerirajPrimBrojeve(100);
            Assert.AreEqual(25, primbrojevi.Length);
            Assert.AreEqual(2, primbrojevi[0]);
            Assert.AreEqual(97, primbrojevi[primbrojevi.Length-1]);
        }

    }
}
