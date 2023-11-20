using eLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LibraryTests
{
    [TestClass]
    public class LibraryTest
    {
        [TestMethod]
        public void TestEvidentaClienti()
        {
            var client = new Client { ID = 1, Nume = "Costel" };
            try
            {
                client.AdaugareEvidentaClienti();
                Assert.IsTrue(true);
            }
            catch
            {
                Assert.IsTrue(false);
            }
        }

        [TestMethod]
        public void CheckIn()
        {
            var angajat = new Angajat { OraIntrareInTura = "08:00", OraIesireDinTura = "10:10" };
            try
            {
                angajat.CheckIn();
                Assert.IsTrue(true);
            }
            catch
            {
                Assert.IsTrue(false);
            }
        }
        [TestMethod]
        public void CheckOut()
        {
            var angajat = new Angajat { OraIntrareInTura = "08:00", OraIesireDinTura = "10:10" };
            try
            {
                angajat.CheckOut();
                Assert.IsTrue(true);
            }
            catch
            {
                Assert.IsTrue(false);
            }
        }
    }
}
