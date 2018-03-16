using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using Eternet.Bancos.Parser;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CheckEmptyHeaderOnConstructor()
        {
            var parserdelimiter = new ParserDelimiter("");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CheckNullHeaderOnConstructor()
        {
            var parserdelimiter = new ParserDelimiter(null);
        }

        [TestMethod]
        public void CheckCharDelimiterComaExpected()
        {
            var parserdelimiter = new ParserDelimiter("col1,col2,col3");
            var chardelimiter = parserdelimiter.GetBestCharDelimiter();
            const char expected = ',';
            Assert.AreEqual(chardelimiter, expected);
        }
    }
}
