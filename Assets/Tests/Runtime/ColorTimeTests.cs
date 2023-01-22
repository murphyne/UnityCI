using System.Collections;
using NUnit.Framework;
using UnityEngine;

namespace Tests.Runtime
{
    public class ColorTimeTests
    {
        private static readonly IEnumerable TestCases = new[]
        {
            new TestCaseData(0.00f, new Color32(0x80, 0x80, 0x80, 0xff)),
            new TestCaseData(0.25f, new Color32(0x40, 0x40, 0x40, 0xff)),
            new TestCaseData(0.50f, new Color32(0x00, 0x00, 0x00, 0xff)),
        };

        [Test]
        [TestCaseSource(typeof(ColorTimeTests), nameof(TestCases))]
        public void TestColorTime(float time, Color32 expected)
        {
            var colorProvider = new ColorTime();
            TestContext.AddFormatter<Color32>(Color32Formatter);

            Color32 actual = colorProvider.GetColor(time);

            Assert.AreEqual(expected, actual);
        }

        private string Color32Formatter(object obj)
        {
            var c = (Color32)obj;
            return $"RGBA(0x{c.r:x2}, 0x{c.g:x2}, 0x{c.b:x2}, 0x{c.a:x2})";
        }
    }
}
