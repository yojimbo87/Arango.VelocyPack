using NUnit.Framework;
using VelocyPack.Segments;

namespace VelocyPack.Tests.SegmentParsing.Numbers
{
    [TestFixture]
    public class DoubleValueTests
    {
        [Test]
        public void ParseDoubleValue()
        {
            // given
            // hex dump of 0 double value
            var data = new byte[] { 0x1b, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 };

            // when
            var segment = VelocyPack.ToSegment(data);

            // then
            Assert.IsInstanceOf<DoubleSegment>(segment);
            Assert.AreEqual(0, segment.StartIndex);
            Assert.AreEqual(9, segment.CursorIndex);
            Assert.AreEqual(data.Length, segment.ByteLength);
            Assert.AreEqual(SegmentType.Double, segment.Type);
            Assert.AreEqual(ValueType.Double, segment.ValueType);
        }
    }
}
