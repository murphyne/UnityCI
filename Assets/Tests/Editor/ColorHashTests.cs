using NUnit.Framework;
using UnityEngine;

namespace Tests.Editor
{
    public class ColorHashTests
    {
        [Test]
        [TestCase("Hello World", 0x02, 0x64, 0xad, 0xff)]
        [TestCase("Hello Superman", 0xb2, 0x07, 0x86, 0xff)]
        [TestCase("Hello Batman", 0x8e, 0x9e, 0x89, 0xff)]
        public void HashCodeTest(string message, byte r, byte g, byte b, byte a)
        {
            TestContext.AddFormatter<Color32>(Color32Formatter);

            Color32 expected = new Color32(r, g, b, a);
            Color32 actual = ColorHash.ComputeHashColor(message);

            Assert.AreEqual(expected, actual);
        }

        private string Color32Formatter(object obj)
        {
            var c = (Color32)obj;
            return $"RGBA(0x{c.r:x2}, 0x{c.g:x2}, 0x{c.b:x2}, 0x{c.a:x2})";
        }
    }
}
