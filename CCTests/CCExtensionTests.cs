using System;
using CCExtensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PWTests
{
    [TestClass]
    public class CCExtensionTests
    {
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestNonNumeric()
        {
            "12345678901234#56".ObfuscateCC();
        }
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestShort()
        {
            "1234567890126".ObfuscateCC();
        }
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestLong()
        {
            "1234567890126423242424242342".ObfuscateCC();
        }
        [TestMethod]
        public void TestWhiteSpace()
        {
            Assert.AreEqual<string>("2342 1234 4567 1234".ObfuscateCC(), "************1234");
            Assert.AreEqual<string>("       23421234 4567 1234 ".ObfuscateCC(), "************1234");
        }
    }
}
