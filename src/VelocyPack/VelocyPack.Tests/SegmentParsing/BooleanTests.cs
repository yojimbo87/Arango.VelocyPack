using NUnit.Framework;
using VelocyPack.Segments;

namespace VelocyPack.Tests.SegmentParsing
{
    [TestFixture]
    public class BooleanTests
    {
        [Test]
        public void ParseFalseBooleanValue()
        {
            // given
            // hex dump of false boolean value
            var data = new byte[] { 0x19 };

            // when
            var segment = VelocyPack.ToSegment(data);

            // then
            Assert.IsInstanceOf<BooleanSegment>(segment);
            Assert.AreEqual(0, segment.StartIndex);
            Assert.AreEqual(1, segment.CursorIndex);
            Assert.AreEqual(data.Length, segment.ByteLength);
            Assert.AreEqual(SegmentType.Boolean, segment.Type);
            Assert.AreEqual(ValueType.False, segment.ValueType);
            Assert.IsNull(segment.SubSegments);
        }

        [Test]
        public void ParseTrueBooleanValue()
        {
            // given
            // hex dump of true boolean value
            var data = new byte[] { 0x1a };

            // when
            var segment = VelocyPack.ToSegment(data);

            // then
            Assert.IsInstanceOf<BooleanSegment>(segment);
            Assert.AreEqual(0, segment.StartIndex);
            Assert.AreEqual(1, segment.CursorIndex);
            Assert.AreEqual(data.Length, segment.ByteLength);
            Assert.AreEqual(SegmentType.Boolean, segment.Type);
            Assert.AreEqual(ValueType.True, segment.ValueType);
            Assert.IsNull(segment.SubSegments);
        }
    }
}
