using NUnit.Framework;
using VelocyPack.Segments;

namespace VelocyPack.Tests.SegmentParsing
{
    [TestFixture]
    public class NullTests
    {
        [Test]
        public void ParseNullnValue()
        {
            // given
            // hex dump of null value
            var data = new byte[] { 0x18 };

            // when
            var segment = VelocyPack.ToSegment(data);

            // then
            Assert.IsInstanceOf<NullSegment>(segment);
            Assert.AreEqual(0, segment.StartIndex);
            Assert.AreEqual(1, segment.CursorIndex);
            Assert.AreEqual(data.Length, segment.ByteLength);
            Assert.AreEqual(SegmentType.Null, segment.Type);
            Assert.AreEqual(ValueType.Null, segment.ValueType);
            Assert.IsNull(segment.SubSegments);
        }
    }
}
