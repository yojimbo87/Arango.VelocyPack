using NUnit.Framework;

namespace VelocyPack.Tests.SegmentParsing.Arrays
{
    [TestFixture]
    public class CompactNonIndexedArrayTests
    {
        [Test]
        public void ParseArrayWithSmallIntegerSubSegments()
        {
            // given
            // hex dump of [1, 2, 3]
            var data = new byte[] { 0x13, 0x06, 0x31, 0x32, 0x33, 0x03 };

            // when
            var segment = VelocyPack.ToSegment(data);

            // then
            // array
            Assert.AreEqual(0, segment.StartIndex);
        }
    }
}
