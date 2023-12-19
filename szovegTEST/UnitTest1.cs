using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Negyszog;
using System.IO;
using Negyzsogg;
namespace KockaTeszt
{
    [TestClass]
    public class Program
    {
        [TestMethod]
        public void TeruletTeszt()
        {
            string varte = "A Négyszög kerülete 34,00, területe: 72,00";
            string kapotte = string.Empty;

            using (var iras = new StringWriter())
            {
                Console.SetOut(iras);
                Negyzsogg.Program.Main();
                kapotte = iras.ToString().Trim();
            }
            Assert.AreEqual(varte,kapotte);
        }
        
    }
}
        


