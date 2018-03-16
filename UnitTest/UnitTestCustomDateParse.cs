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
            var mydate = str.ToProcinciaDateTime();
            Assert.AreEqual(mydate, expected);
        }
    }

}
