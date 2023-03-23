using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace helloworldmstest.test
{
    [TestClass]
    public class MstestTrueTesting
    {
        [TestMethod]
        public void IsTrueAndTrue()
        {
            Assert.IsTrue(true, "It is true");
        }

        [TestMethod]
        public void IsTrueButFalse()
        {
            Assert.IsTrue(true, "It was false!");
        }
    }
}
