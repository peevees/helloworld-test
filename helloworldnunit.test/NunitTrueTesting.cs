using NUnit.Framework;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            //set something up for the test
        }

        [Test]
        public void IsTrueAndTrue()
        {
            Assert.IsTrue(true, "It is true");
        }

        [Test, Explicit]
        [Ignore("Ignore since it will always break")]
        public void IsTrueButFalse()
        {
            Assert.IsTrue(false, "It was false");
        }
    }
}
