using NUnit.Framework;

namespace Tests
{
    public class Tests
    {
        

        //[SetUp]
        //public void Setup()
        //{
        //}

        [Test]
        public void IsTrueAndTrue()
        {
            Assert.IsTrue(true, "It is true");
        }

        [Test]
        public void IsTrueButFalse()
        {
            Assert.IsTrue(false, "It was false");
        }
    }
}