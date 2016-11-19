using NUnit.Framework;
using VelocyPack.Segments;

namespace VelocyPack.Tests.SegmentParsing
{
    [TestFixture]
    public class NonSensicalValueTests
    {
        [Test]
        public void ParseMinKeyValue()
        {
            // given
            // hex dump of minKey value
            var data = new byte[] { 0x1e };

            // when
            var segment = VelocyPack.ToSegment(data);

            // then
            Assert.IsInstanceOf<NonSensicalSegment>(segment);
            Assert.AreEqual(0, segment.StartIndex);
            Assert.AreEqual(1, segment.CursorIndex);
            Assert.AreEqual(data.Length, segment.ByteLength);
            Assert.AreEqual(SegmentType.NonSensical, segment.Type);
            Assert.AreEqual(ValueType.MinKey, segment.ValueType);
        }

        [Test]
        public void ParseMaxKeyValue()
        {
            // given
            // hex dump of maxKey value
            var data = new byte[] { 0x1f };

            // when
            var segment = VelocyPack.ToSegment(data);

            // then
            Assert.IsInstanceOf<NonSensicalSegment>(segment);
            Assert.AreEqual(0, segment.StartIndex);
            Assert.AreEqual(1, segment.CursorIndex);
            Assert.AreEqual(data.Length, segment.ByteLength);
            Assert.AreEqual(SegmentType.NonSensical, segment.Type);
            Assert.AreEqual(ValueType.MaxKey, segment.ValueType);
        }
    }
}
