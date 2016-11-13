using NUnit.Framework;

namespace VelocyPack.Tests.SegmentParsing.Arrays
{
    [TestFixture]
    public class EmptyArrayTests
    {
        [Test]
        public void ParseEmptyArray()
        {
            // given
            // hex dump of [1, 2, 3]
            var data = new byte[] { 0x01 };

            // when
            var segment = VelocyPack.ToSegment(data);

            // then
            // array
            Assert.AreEqual(0, segment.StartIndex);
            Assert.AreEqual(1, segment.CursorIndex);
            Assert.AreEqual(SegmentType.Array, segment.Type);
            Assert.AreEqual(ValueType.EmptyArray, segment.ValueType);
            Assert.AreEqual(0, segment.SubSegments.Count);
        }
    }
}
