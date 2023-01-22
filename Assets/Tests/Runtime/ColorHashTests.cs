using System.Collections;
using NUnit.Framework;
using UnityEngine;

namespace Tests.Runtime
{
    public class ColorHashTests
    {
        private static readonly IEnumerable TestCases = new[]
        {
            new TestCaseData("Hello World", new Color32(0x02, 0x64, 0xad, 0xff)),
            new TestCaseData("Hello Superman", new Color32(0xb2, 0x07, 0x86, 0xff)),
            new TestCaseData("Hello Batman", new Color32(0x8e, 0x9e, 0x89, 0xff)),
        };

        [Test]
        [TestCaseSource(typeof(ColorHashTests), nameof(TestCases))]
        public void HashCodeTest(string message, Color32 expected)
        {
            TestContext.AddFormatter<Color32>(Color32Formatter);

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
