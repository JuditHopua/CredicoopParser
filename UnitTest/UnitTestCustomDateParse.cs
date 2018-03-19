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
        public void CheckCustomDateParseCredicoop()
        {
            const string str = "29/12/2017";
            var mydate = str.ToCredicoopDateTime();
            var expected = new DateTime(2017, 12, 29);
            Assert.AreEqual(mydate, expected);
        }

        [TestMethod]
        public void CheckCustomDecimalParse()
        {
            const string str = "3125,18";
            var myDecimal = str.ToDecimal();
            var expected = 3125.18m;
            Assert.AreEqual(myDecimal, expected);
        }
    }

}
