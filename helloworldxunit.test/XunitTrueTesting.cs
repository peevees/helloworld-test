using System;
using System.Reflection;
using Xunit;

namespace helloworldxunit.test
{
    public class XunitTrueTesting
    {
        [Fact]
        public void IsTrueAndTrue()
        {
            Assert.True(true, "It is true");
        }

        [Fact(Skip = "Ignore since it will always break")]
        public void IsTrueButFalse()
        {
            Assert.True(false, "It was false");
        }
    }
}
