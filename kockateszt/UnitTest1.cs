using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Negyszog;

namespace KockaTeszt
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TeruletTeszt()
        {

            NegyszogClass sz = new NegyszogClass(3, 5);
            sz.SetTerulet();

            double vart = 15,
            kapott = sz.getTerulet();
            Assert.AreEqual(vart, kapott);


        }

        public void KeruletTeszt()
        {
            NegyszogClass sz = new NegyszogClass(3, 5);
            sz.SetKerulet();

            double vartt = 16,
            kapottt = sz.getKerulet();
            Assert.AreEqual(vartt, kapottt);
        }
    }
}

