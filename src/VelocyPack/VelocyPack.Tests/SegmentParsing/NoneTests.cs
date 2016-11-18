using NUnit.Framework;
using VelocyPack.Segments;

namespace VelocyPack.Tests.SegmentParsing
{
    [TestFixture]
    public class NoneTests
    {
        [Test]
        public void ParseNoneValue()
        {
            // given
            // hex dump of none value
            var data = new byte[] { 0x00 };

            // when
            var segment = VelocyPack.ToSegment(data);

            // then
            Assert.IsInstanceOf<NoneSegment>(segment);
            Assert.AreEqual(0, segment.StartIndex);
            Assert.AreEqual(1, segment.CursorIndex);
            Assert.AreEqual(data.Length, segment.ByteLength);
            Assert.AreEqual(SegmentType.None, segment.Type);
            Assert.AreEqual(ValueType.None, segment.ValueType);
            Assert.IsNull(segment.SubSegments);
        }
    }
}
