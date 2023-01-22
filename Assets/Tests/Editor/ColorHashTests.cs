using System.Collections;
using NUnit.Framework;
using UnityEngine;

namespace Tests.Editor
{
    public class ColorHashTests
    {
        private static readonly IEnumerable TestCases = new[]
        {
            new TestCaseData(0.00f, new Color32(0x80, 0x80, 0x80, 0xff)),
            new TestCaseData(0.25f, new Color32(0x40, 0x40, 0x40, 0xff)),
            new TestCaseData(0.50f, new Color32(0x00, 0x00, 0x00, 0xff)),
        };

        [Test]
        [TestCaseSource(typeof(ColorHashTests), nameof(TestCases))]
        public void HashCodeTest(float time, Color32 expected)
        {
            TestContext.AddFormatter<Color32>(Color32Formatter);

            Color32 actual = ColorHash.ComputeHashColor(time);

            Assert.AreEqual(expected, actual);
        }

        private string Color32Formatter(object obj)
        {
            var c = (Color32)obj;
            return $"RGBA(0x{c.r:x2}, 0x{c.g:x2}, 0x{c.b:x2}, 0x{c.a:x2})";
        }
    }
}
