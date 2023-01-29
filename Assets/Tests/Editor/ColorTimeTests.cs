using System.Collections;
using NUnit.Framework;
using UnityEngine;

namespace Tests.Editor
{
    public class ColorTimeTests
    {
        private static readonly IEnumerable TestCases = new[]
        {
            new TestCaseData(0.00f, new Color32(0x80, 0xee, 0x11, 0xff)),
            new TestCaseData(0.20f, new Color32(0xf9, 0x65, 0x21, 0xff)),
            new TestCaseData(0.35f, new Color32(0xe7, 0x0b, 0x8d, 0xff)),
            new TestCaseData(0.50f, new Color32(0x7f, 0x11, 0xee, 0xff)),
            new TestCaseData(0.65f, new Color32(0x18, 0x72, 0xf4, 0xff)),
            new TestCaseData(0.80f, new Color32(0x06, 0xde, 0x9a, 0xff)),
            new TestCaseData(1.00f, new Color32(0x80, 0xee, 0x11, 0xff)),
        };

        [Test]
        [TestCaseSource(typeof(ColorTimeTests), nameof(TestCases))]
        public void TestColorTime(float time, Color32 expected)
        {
            var colorProvider = new ColorTime();
            TestContext.AddFormatter<Color32>(Color32Formatter);

            Color32 actual = colorProvider.GetColor(time);

            var tolerance = 1;
            var areEqual = true;
            areEqual &= Mathf.Abs(expected.r - actual.r) <= tolerance;
            areEqual &= Mathf.Abs(expected.g - actual.g) <= tolerance;
            areEqual &= Mathf.Abs(expected.b - actual.b) <= tolerance;
            areEqual &= Mathf.Abs(expected.a - actual.a) <= tolerance;

            if (!areEqual)
                Assert.AreEqual(expected, actual);
        }

        private string Color32Formatter(object obj)
        {
            var c = (Color32)obj;
            return $"RGBA(0x{c.r:x2}, 0x{c.g:x2}, 0x{c.b:x2}, 0x{c.a:x2})";
        }
    }
}
