using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace metno.Test.Unit
{
    [TestClass]
    public class ParserTest
    {        
        [TestMethod]
        public void ParserReturnsCorrect()
        {
            var htmlToBeStripped = "<html>Test</html>";
            var result = Parser.StripHtml(htmlToBeStripped);

            Assert.IsTrue(result.Equals("Test"));
        }
    }
}
