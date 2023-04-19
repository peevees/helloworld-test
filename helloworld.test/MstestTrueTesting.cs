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
        [Ignore("Ignore since it will always break")]
        public void IsTrueButFalse()
        {
            Assert.IsTrue(false, "It was false!");
        }
    }
}

