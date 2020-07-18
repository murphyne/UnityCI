using NUnit.Framework;

namespace Tests.Runtime
{
    public class ColorHashTests
    {
        [Test]
        [TestCase("Hello World", 40152618)]
        [TestCase("Hello Superman", -1291352238)]
        [TestCase("Hello Batman", -1885369767)]
        public void HashCodeTest(string message, int hashCode)
        {
            var actual = ColorHash.ComputeHashFromString(message);
            Assert.AreEqual(hashCode, actual);
        }
    }
}
