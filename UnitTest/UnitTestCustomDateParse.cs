using Eternet.Bancos.Parser.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTest
{
    [TestClass]
    public class UnitTestCustomDateParse
    {

        [TestMethod]
        public void CheckCustomDateParseProvincia()
        {
            const string str = "29-dic-2017";
            var expected = new DateTime(2017, 12, 29);
            var mydate = str.ToProvinciaDateTime();
            Assert.AreEqual(mydate, expected);
        }

        [TestMethod]
        public void CheckCustomDateParseWithSlash()
        {
            const string str = "29/12/2017";
            var mydate = str.ToSlashDateTime();
            var expected = new DateTime(2017, 12, 29);
            Assert.AreEqual(mydate, expected);
        }

        [TestMethod]
        public void CheckCustomDateParseFrances()
        {
            const string str = "29-12-2017";
            var mydate = str.ToFrancesDateTime();
            var expected = new DateTime(2017, 12, 29);
            Assert.AreEqual(mydate, expected);
        }

        [TestMethod]
        public void CheckCustomDecimalSeparatorParse()
        {
            const string str = "3125,18";
            var myDecimal = str.ToDecimal();
            var expected = 3125.18m;
            Assert.AreEqual(myDecimal, expected);
        }

        [TestMethod]
        public void CheckCustomEmptyDecimalParse()
        {
            const string str = "";
            var myDecimal = str.ToDecimal();
            var expected = 0.00m;
            Assert.AreEqual(myDecimal, expected);
        }
    }

}
