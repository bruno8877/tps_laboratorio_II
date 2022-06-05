using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;

namespace TestUnitarios
{
    [TestClass]
    public class TestUnitarios
    {
        [TestMethod]
        public void Auto_Igual_Color()
        {
           
            AutoFam autofam = new AutoFam("Rojo", "Goodyear", "Ford");

            Auto auto = new Auto("Negro", "Michelin", "Chevrolet", Auto.Cilindrada.cc3000);
                
            Assert.AreNotEqual(autofam.Color, auto.Color);
            
        }

        [TestMethod]
        public void Auto_List_Vacia()
        {
            Concesionaria c1 = new Concesionaria(6);

            AutoFam autofam = new AutoFam("Rojo", "Goodyear", "Ford");

            c1 += autofam;


            Assert.IsNotNull(c1.Vehiculos);
            Assert.IsTrue(c1.Vehiculos.Count>0);

        }
    }
}
