using Microsoft.VisualStudio.TestTools.UnitTesting;
using CanonDemoNS;

namespace CanonDemoTests
{
    [TestClass]
    public class CanonDemoTests
    {
        [TestMethod]
        public void NormalTestCase()
        {
            uint expected = 10;
            uint actual = OctalUtility.OctalToUInt("012");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CheckUpperLimit()
        {
            uint expected = 0;
            uint actual = OctalUtility.OctalToUInt("0");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CheckLowerLimit()
        {
            uint expected = 4294967295;
            uint actual = OctalUtility.OctalToUInt("37777777777");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void OutOfBounds()
        {

            uint res = 0;
            try
            {
                res = OctalUtility.OctalToUInt("777777777777");
            }
            catch (System.OverflowException e)
            {
                StringAssert.Contains(e.Message, "Arithmetic operation resulted in an overflow.");
                return;
            }

            Assert.Fail("The expected exception was not thrown.");
        }

        [TestMethod]
        public void ParseError()
        {
            uint res = 0;
            try
            {
                res = OctalUtility.OctalToUInt("/asdf");
            }
            catch (System.Exception e)
            {
                StringAssert.Contains(e.Message, "Parse failed - not a valid octal string");
                return;
            }

            Assert.Fail("The expected exception was not thrown.");
        }
    }
}
