using Eternet.Bancos.Interpreter.DataFinder;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    [TestClass]
    public class UnitTestBancosInterpreter
    {
        [TestMethod]
        public void CheckExtractNumbersFromConceptNull()
        {
            const string str = "";
            var myNumbers = FromConcept.ExtractNumbersFromConcept(str);
            const string expected = "";
            Assert.AreEqual(myNumbers.Count, expected.Length);
        }

        [TestMethod]
        public void CheckExtractNumbersFromConcept()
        {
            const string str = "BIP DB.TR.04/12-C.566630 DES:3121-20-1911040137857";
            var myNumbers = FromConcept.ExtractNumbersFromConcept(str);
            const int expected = 6;
            Assert.AreEqual(myNumbers.Count, expected);
        }

        [TestMethod]
        public void CheckExtractStringFromConceptNull()
        {
            const string str = "";
            var myNumbers = FromConcept.ExtractStringsFromConcept(str);
            const string expected = "";
            Assert.AreEqual(myNumbers.Count, expected.Length);
        }

        [TestMethod]
        public void CheckExtractStringsFromConcept()
        {
            const string str = "BIP DB.TR.04/12-C.566630 DES:3121-20-1911040137857";
            var myNumbers = FromConcept.ExtractStringsFromConcept(str);
            const int expected = 6;
            Assert.AreEqual(myNumbers.Count, expected);
        }

        [TestMethod]
        public void CheckCalcularDigitoCuit()
        {
            const string str = "3068134835";
            var myCuit = FromConcept.CalcularDigitoCuit(str);
            const long expected = 9;
            Assert.AreEqual(myCuit, expected);
        }

        [TestMethod]
        public void CheckIsACuit()
        {
            const string cuit = "30681348359";
            var isACuit = FromConcept.ValidaCuit(cuit);
            Assert.IsTrue(isACuit);
        }

        [TestMethod]
        public void CheckCuitIsNull()
        {
            const string cuit = "";
            var cuitIsNull = FromConcept.ValidaCuit(cuit);
            Assert.IsFalse(cuitIsNull);

        }

        [TestMethod]
        public void CheckIsADni()
        {
            const string dni = "68134835";
            var isADni = FromConcept.ValidaDni(dni);
            Assert.IsTrue(isADni);
        }

        [TestMethod]
        public void CheckDniIsNull()
        {
            const string dni = "";
            var dniIsNull = FromConcept.ValidaDni(dni);
            Assert.IsFalse(dniIsNull);
        }
    }
}
