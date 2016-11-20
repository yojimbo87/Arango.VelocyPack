using NUnit.Framework;
using VelocyPack.Segments;

namespace VelocyPack.Tests.Segmentation
{
    [TestFixture]
    public class NoneValueTests
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
            Assert.AreEqual(0, segment.ValueStartIndex);
            Assert.AreEqual(1, segment.ValueByteLength);
        }
    }
}
